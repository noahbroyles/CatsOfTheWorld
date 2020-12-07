/* INSTRUCTOR:
 * Bill Nicholson
 * nicholdw@ucmail.uc.edu
 */

/* STUDENT:
 * Name: Noah Broyles
 * Email: broylend@mail.uc.edu
 * Contemporary Programming Final Assignment
 * Due Date: 12/08/2020
 * Description: Final Exam program for Contemporary Programming Fall 2020.
 * Citations:
 * 
 */
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CatsOfTheWorld {
    public partial class frmCatsOfTheWorld : Form {

        List<Cat> cats;
        public frmCatsOfTheWorld() {
            InitializeComponent();
            cats = new List<Cat>();
        }
       
        
        // ToDo 2. Get rid of this method, it's annoying
        // Gone.

        private void btnAddCat_Click(object sender, EventArgs e) {
            // ToDo  1. Add a new cat to cats List using the contents of txtCat as the name.
            cats.Add(new Cat(txtCat.Text));

        }

        private void btnCopyCats_Click(object sender, EventArgs e) {
            //  ToDo 3. Copy the contents of the cats List to the list box: 
            //          one element in the list becomes one item in the ListBox
            foreach (Cat c in cats) {
                lbCatsOnFile.Items.Add(c.name);
            }
        }

        // ToDo 5: Add a button on the form and associated logic to clear lbCatsOnFile when clicked
        private void clearButton_Click(object sender, EventArgs e) {
            lbCatsOnFile.Items.Clear();
        }


    }
}
