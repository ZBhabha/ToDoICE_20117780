using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{ 
   

   
    public partial class Form1 : Form
    {
        

         

        public Form1()
        {
            InitializeComponent();
            TextFileUtil.writeToFile(ListUtil.toDoList);
            ListUtil.toDoList = TextFileUtil.readFromFile();

            //Picture on form taken from
            //Author:Marco Verch 
            //https://ccnull.de/foto/hands-holding-clipboard-with-to-do-list/1020658

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        /*
         * What is the purpose of a create button if you are writing to a
         * file when the user clicks on add?
         */

        private void btnCreate_Click(object sender, EventArgs e)
        {
            
            lstbxDo.Items.Clear();
            MessageBox.Show("To do list successfully created and stored!","SUCCESS!",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string description= txbAdd.Text;

            string priority = txbPriority.Text;
            DateTime date = dtpDate.Value;

            txbAdd.Clear();
            txbPriority.Clear();

            ToDo A1 = new ToDo(description,date,priority);

            ListUtil.toDoList.Add(A1);
            TextFileUtil.writeToFile(A1);

            lstbxDo.Items.Add(A1.ToString());

           // TextFileUtil.writeToFile(ListUtil.toDoList);
            //lstbxDo.Items.Add(txbAdd.Text);
            //lstbxDo.Items.Add(txbPriority.Text);
            //lstbxDo.Items.Add(dtpDate.Value);


            //MessageBox.Show(A1.Description+A1.Date+A1.Priority.ToString());

        }



        private void Form1_Load(object sender, EventArgs e)
        {
           // code to clear list box each time the form loads so that each user can store their different tasks wihout mixing them up
            
            lstbxDo.Items.Clear();
           


           
            
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lstbxDo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
