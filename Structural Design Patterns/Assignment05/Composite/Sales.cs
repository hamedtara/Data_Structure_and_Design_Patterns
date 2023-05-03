using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment05.Composite
{
    public class Sales : Departmnet
    {
        

        public int Id { get; set; }
        public string Name { get; set; }

        public Sales (int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void getdepartmentDetail()
        {
            Console.WriteLine(Id + ""+ Name);
        }

    }
}

/*Imagine you have a set of toys, and each toy is either a simple toy, \
 * like a ball or a doll, or a set of toys, like a toy box that contains other toys. 
 * Now, let's say you want to play with all the toys, but you don't want to have to think about whether you're playing with a simple toy or a set of toys.

That's where the Composite Design Pattern comes in! It's a way of organizing the toys so that you can treat them all the same way,
whether they're simple toys or sets of toys. The pattern gives you a way to group the toys together in a tree-like structure, where 
each toy is either a leaf (a simple toy) or a branch (a set of toys).

So, if you want to play with all the toys, you can start at the top of the tree and work your way down,\
playing with each toy as you come to it. And the best part is, you don't have to worry about whether
a toy is a simple toy or a set of toys – you can just play with it the same way, no matter what!*/