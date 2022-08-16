using SingleLinkedList.CLinkedList;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SingleLinkedList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SLinkedList slinkedlist = new SLinkedList();
            slinkedlist.appendNode("I am the Head");
            slinkedlist.appendNode("I am the Second Node");
            slinkedlist.appendNode("I am the Third Node");

            slinkedlist.prepend("I am the new head");
            slinkedlist.prepend("Mwaahaahaa Im the new head now");
            slinkedlist.prepend("I am the captain");

            //slinkedlist.deleteWithData("Look at me, I am the captain now");
            slinkedlist.applyProfanityFilter("I am the captain");
            slinkedlist.applyProfanityFilter("am");
            slinkedlist.insertAfter("I have been inserted after", "");

            

           
           
        }

    }
}
