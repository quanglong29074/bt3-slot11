using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.demo4
{
    public delegate void UpdateQtyHandler(int n);
    public class Product
    {
        private int qty;

        public event UpdateQtyHandler QtyChanged;

        public Product()
        {
            QtyChanged += SenEmailToadmin;
            QtyChanged += SenSMSToStoreManger;
            QtyChanged += IncrementQty;
        }

        public int Qty
        {
            get => qty;
            set => qty = value;
        }

        public void MotifyChangeQty(int n)
        {
            Console.WriteLine("Qty product was changed" + n);
        }

        public void SenEmailToadmin(int n)
        {
            //Sen Email
        }

        public void SenSMSToStoreManger(int n)
        {
            //Sen sms
        }

        public void IncrementQty(int q)
        {
            if(q>0) {
                qty += q;
                QtyChanged(q);
            }
        }
    }
}
