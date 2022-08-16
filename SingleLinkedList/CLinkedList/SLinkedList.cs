using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SingleLinkedList.CLinkedList
{
    internal class SLinkedList
    {
        CustomNode head;
        CustomNode current;
        String data;
        int nodeCount;

        public void appendNode(string data)
        {
            //if a list is empty make a node and call it head
            if (head == null)
            {
                head = new CustomNode();
                nodeCount++;
                return;
            }
            current = head;

            while (current.Next != null)
            {
                current =
                      current.Next;

            }
            current.Next = new CustomNode(data);
        }
        public void prepend(string data)
        {
            if (head != null)
            {
                head = new CustomNode(data);
            }
            else
            {
                CustomNode newHead = new CustomNode(data);
                nodeCount++;
                newHead.Next = head;
                head = newHead;
            }



        }
        public void deleteWithData(string data)
        {
            if (head == null)
            {
                MessageBox.Show("Cannot delete a value from an empty list");
                return;
            }

            if (head.data.Equals(data))
            {
                head = head.Next;
            }
            //if the node we want to delete is not the head, we need to walk the list
            current = head;
            while (current.Next != null)
            {
                if (current.data.Equals(data))
                {
                    current = current.Next.Next;
                    MessageBox.Show("Node with data" + data + "deleted"); 
                }
                current = current.Next;
            }
            MessageBox.Show("Could not delete data,  data not present in list");

        }

        public void applyProfanityFilter(string data)
        {
            if (head == null)
            {
                MessageBox.Show("No lists to clean");
            }

            if (head.data.Contains(data))
            {
                string replaceString = head.data.Replace(data, "*****");
                head.data = replaceString;
                MessageBox.Show(head.data);
                return;
            }

            head = current;

            while (current.Next != null)
            {
                current = current.Next;
                if (current.data.Contains(data))
                {
                    string replaceSTRING = current.data.Replace(data, "*****");
                    head.data = replaceSTRING;
                    MessageBox.Show(current.data);


                }
            }

            MessageBox.Show("No swear words in here");
        }

            public void insertAfter(string nodeData, string searchData)
            {
                if (head ==null)
                {
                    MessageBox.Show("There is no list");
                }

                if (head.data.Contains(searchData))
                {
                    CustomNode insertNode = new CustomNode(nodeData);
                    insertNode.Next = head.Next;
                    head.Next = insertNode;
                }
            }
        }
        

            

            





    }
  }
