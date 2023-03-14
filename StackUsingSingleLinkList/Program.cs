using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackUsingSingleLinkList
{
    class node
        //method ini digunakan untuk cetakan sebuah objek
    {
        public int info; //public keyword menandakan bahwa atribut dapat diakses dari class lain.
                         //int digunakan untuk data yang berbentuk bilangan bulat atau numerik.
        public node next;//node digunakan untuk mengirimkan data dan informasi
        public node(int i, node n)
        {
            info = i;//penamaan atau objek awal
            next = n;//penamaan untuk objek selanjutnya
        }
    }

    class Stack
        //method yang digunakan untuk mengontrol operasi
    {
        node top;
        public Stack()
        {
            top = null;
        }
        bool empty()
            //digunakan untuk perbandingan jika kosong
        {
            if (top == null)//jika top sama dengan null
                return (true);//maka dapat kembali
            else
                return (false);//jika tidak maka tidak dapat kembali
        }

        public void push(int element)
            //method yang digunakan untuk menambahkan objek
        {
            node fresh;
            fresh = new node(element, null);

            fresh.next = top;
            top = fresh;
            Console.WriteLine("\n" + element + " pushed");
            //angka selanjutnya akan berada di atas(angka yang baru saja di masukkan)
        }

        public void pop()
            //method yang digunakan untuk memanggil objek
        {
            Console.WriteLine("\nThe poped elements is: " + top.info);
            top = top.next; // make top point to the next node is squence
        }

        public void display()
            //method yang digunakan untuk mendisplay atau menampilkan objek
        {
            node tmp;
            if (empty())
                Console.WriteLine("\nStack Empty");
            //jika stack kosong maka akan ditampilkan "stack empty"
            else
            {
                for (tmp = top; tmp != null; tmp = tmp.next)//untuk yang ditmapilakn top(yang terakhir kali dimasukkan), untuk yang ditampilkan tidak boleh sama dengan null, angka selanjutnya
                {
                    Console.WriteLine(tmp.info);
                }
                //jika tidak maka akan ditmapilkan tmp.info(angka)
            }
        }
        

        static void Main(string[] args)
            //Setelah kita membuat fungsi, selanjutnya kita bisa mengeksekusi fungsinya. Fungsi dapat dipanggil dari fungsi main atau dari fungsi yang lainnya.
        {
            Stack s = new Stack();
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("\n***Stack Menu***\n");
                Console.WriteLine("1. Push");
                Console.WriteLine("2. Pop");
                Console.WriteLine("3. Display");
                Console.WriteLine("4. Exit");
                Console.Write("\nEnter your choice: ");
                string Input = Console.ReadLine();
                char ch = Convert.ToChar(Input == "" ? "0" : Input);//berhuna untuk menerima input
                switch (ch)
                {
                    case '1':
                        Console.WriteLine("\nEnter a number :");
                        int num = Convert.ToInt32(Console.ReadLine());
                        s.push(num);
                        break;
                        //berguna untuk memasukkan atau mendorong objek
                    case '2':
                        if (s.empty())
                        {
                            Console.WriteLine("\nStack empty");
                            break;               
                        }
                        s.pop();
                        break;
                    //berguna untuk memberitahu bahwa stack kosong
                    case '3':
                        s.display();
                        break;
                        //berguna untuk menampilkan objek yang sudah di masukkan
                    case '4':
                        return;
                    default:
                        Console.WriteLine("\nInvalid Choice");
                        break;
                        //berguna untuk menampilka jika salah memilih
                }
            }
        }
    }
}
