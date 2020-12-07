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

namespace CatsOfTheWorld {
    /// <summary>
    /// Cat Model
    /// </summary>
    class Cat {
        private String mName;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">Name of the cat</param>
        public Cat(String name) {
            // ToDo  4. If name is blank or null, throw an exception and don't create the new Cat object
            if (name.Trim().Length == 0 || name is null) {
                throw new Exception("Error: Cat name cannont be blank or null");
            } else {
                mName = name;
            }
        }

        public String name {
            get { return mName; }
            set { mName = value; }
        }
    }
}
