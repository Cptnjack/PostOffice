using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO
{
    class LabelQueue
    {
       
        private const int MAXSIZE = 30;
        private Label [] labels;
        public LabelQueue()
        {
            labels = new Label[MAXSIZE];
        }

        public LabelQueue(Label l)
        {
            labels = new Label[MAXSIZE];
            labels[0] = l;
        }

        public LabelQueue(Label [] a)
        {
            labels = a;
        }

        public LabelQueue(LabelQueue q)
        {
            this.labels = q.labels;
        }
    }
}
