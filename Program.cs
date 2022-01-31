using System;
namespace addressbook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContactDetails contactDetailUC1 = new ContactDetails();
            contactDetailUC1.Details();

            AddContact addNewContactUC2 = new AddContact();
            addNewContactUC2.EnterInput();
            addNewContactUC2.ViewTheDetails();

           // DuplicateEntry duplicateEntry = new DuplicateEntry();
            //duplicateEntry.duplicate();

            EditContact editDetailsUC3 = new EditContact();
            editDetailsUC3.EditName();

            DeleteContact deleteDetailsUC4 = new DeleteContact();
            deleteDetailsUC4.DeleteName();

           


           // doListDemo();
            //doStackDemo();
            //doQueueDemo();
            //doSetDemo();
            //doDictionary();
        }

       /* private static void doDictionary()
        {
            Console.WriteLine("\n In DictionaryDemo");
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(100, "Amit");
            dictionary.Add(101, "Rahul");
            dictionary.Add(102, "Amith");
            Console.WriteLine("Access values using key(key=100)" + dictionary[100]);
            Console.WriteLine("\nIterating Dictionary");
            foreach (var element in dictionary)
            {
                Console.WriteLine("key=" + element.Key + "& value" + element.Value);
            }
        }


        private static void doSetDemo()
        {
            Console.WriteLine("\nIn doSetDemo");
            var set = new HashSet<string>();
            set.Add("Ravi");
            set.Add("Ravinder");
            set.Add("Subha");
            foreach (var element in set)
            {
                Console.WriteLine(element);
            }
        }



        private static void doQueueDemo()
        {
            Console.WriteLine("\n In doQueueDemo");
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Sri");
            queue.Enqueue("Raj");
            queue.Enqueue("Jai");

            Console.WriteLine("Head:" + queue.Peek());
            Console.WriteLine("\nIterating the queue elements");
            foreach (var element in queue)
            {
                Console.WriteLine(element);
            }

            string dequeue = queue.Dequeue();
            Console.WriteLine("Dequeue element:" + dequeue);
            Console.WriteLine("\nIterating the queue elements after dequeue");
            foreach (var element in queue)
            {
                Console.WriteLine(element);
            }
        }



        private static void doStackDemo()
        {
            Console.WriteLine("\n In doStackDemo");
            Stack<string> stack = new Stack<string>();
            stack.Push("Ayush");
            stack.Push("Amit");
            stack.Push("Ayesha");
            string pop = stack.Pop();
            foreach (var element in stack)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("Popped element:" + pop);
        }


        private static void doListDemo()
        {
            Console.WriteLine("\nIn doListDemo");
            List<string> list = new List<string>();
            list.Add("Ravi");
            list.Add("Vijay");
            list.Add("Ravi");
            list.Add("Ajay");
            foreach (var element in list)
            {
                Console.WriteLine(element);

            }
        }*/
    }
}









            
        
    






    



    

