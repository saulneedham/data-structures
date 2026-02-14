using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADSPortEx1
{

    class GuestQueue
    {

        private int maxSize = 10;
        private int head = 0;
        private int tail = 0;
        private int numItems = 0;
        private Guest[] store;

        public GuestQueue()
        {
            store = new Guest[maxSize];
        }

        public GuestQueue(int size)
        {
            maxSize = size;
            store = new Guest[maxSize];
        }

        public void Enqueue(Guest value)
        {
            store[tail] = value;
            tail = (tail + 1) % maxSize;
            numItems++;
        }

        public Guest Dequeue()
        {
            Guest headItem = store[head];
            head = (head + 1) % maxSize;
            numItems--;
            return headItem;
        }

        public Guest Peek()
        {
            return store[head];
        }

        public int Count()
        {
            return numItems;
        }

        public bool IsEmpty()
        {
            return (numItems == 0);
        }

        public bool IsFull()
        {
            return (numItems == maxSize);
        }

        public void Reverse(int k)
        {
            int lPointer = head; //first index of list
            int rPointer = (head+k-1) % maxSize; //final index to be reversed
            while (lPointer < rPointer)
            {
                Guest temp = store[lPointer];
                store[lPointer] = store[rPointer];
                store[rPointer] = temp;

                lPointer++;
                rPointer--;
            }
        }

        public Guest GetMostFunds()
        {
            Guest richestGuest = store[head];

            for (int i = head + 1; i < tail; i++)
            {
                if (store[i].Funds > richestGuest.Funds)
                {
                    richestGuest = store[i];
                }
            }

            return richestGuest;
        }

    }
}
