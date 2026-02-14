using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace ADSPortEx1
{
    public partial class Form1 : Form
    {
        private GuestQueue guestQueue = new GuestQueue();
        public Form1()
        {
            InitializeComponent();
        }

        private void Enqueue_Click(object sender, EventArgs e)
        {
            string name = nameEntry.Text;
            int funds = Convert.ToInt16(fundsEntry.Text);
            Guest guest = new Guest(name, funds);
            if (guestQueue.IsFull())
            {
                MessageBox.Show("Queue is full - Cannot add guest");
            }
            else
            {
                guestQueue.Enqueue(guest);

                MessageBox.Show($"Enqueued Guest: {guest.Name}");
            }

            nameEntry.Text = "";
            fundsEntry.Text = "";
        }

        private void Dequeue_Click(object sender, EventArgs e)
        {
            if (guestQueue.IsEmpty())
            {
                MessageBox.Show("Queue is empty - nothing to dequeue");
            }
            else
            {
                Guest guest = guestQueue.Dequeue();

                MessageBox.Show($"Dequeued Guest: {guest.Name}");
            }
        }

        private void Peek_Click(object sender, EventArgs e)
        {
            if (guestQueue.IsEmpty())
            {
                MessageBox.Show("Queue is empty - nothing to peek");
            }
            else
            {
                Guest guest = guestQueue.Peek();

                MessageBox.Show($"Peeked Guest: {guest.Name}");
            }
        }

        private void Count_Click(object sender, EventArgs e)
        {
            int count = guestQueue.Count();

            MessageBox.Show($"Number of Guests in queue: {count}");
        }

        private void IsEmpty_Click(object sender, EventArgs e)
        {
            if (guestQueue.IsEmpty())
            {
                MessageBox.Show($"The queue is empty");
            }
            else
            {
                MessageBox.Show($"The queue is not empty");
            }
        }

        private void IsFull_Click(object sender, EventArgs e)
        {
            if (guestQueue.IsFull())
            {
                MessageBox.Show($"The queue is full");
            }
            else
            {
                MessageBox.Show($"The queue is not full");
            }
        }

        private void Reverse_Click(object sender, EventArgs e)
        {
            int k = Convert.ToInt16(kEntry.Text);

            if (k>guestQueue.Count())
            {
                MessageBox.Show($"k value cannot be larger than queue size");
            }
            else
            {
                guestQueue.Reverse(k);

                MessageBox.Show($"First k items reversed");

                kEntry.Text = "";
            }
        }

        private void GMFunds_Click(object sender, EventArgs e)
        {
            if (guestQueue.IsEmpty())
            {
                MessageBox.Show("Queue is empty - no guests to check");
            }
            else
            {
                Guest richestGuest = guestQueue.GetMostFunds();

                MessageBox.Show($"Richest Guest: {richestGuest.Name}");
            }
        }
    }
}
