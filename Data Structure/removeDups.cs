class Program
    {
        static void Main(string[] args)
        {
            var mainList = new LinkedListNode(3);
            mainList.AddList(15);
            mainList.AddList(12);
            mainList.AddList(3);
            mainList.AddList(3);
            mainList.AddList(14);

            var result = DeleteDups(mainList);
        }

        public static LinkedListNode DeleteDups(LinkedListNode list)
        {
            HashSet<int> listValue = new HashSet<int>();
            LinkedListNode newList = list;
            var returnList = newList;
            while (list != null)
            {
                if(!listValue.Contains(list.data))
                {
                    newList = list;
                    listValue.Add(list.data);
                }else
                {
                    newList.Next = list.Next;
                }
                list = list.Next;
            }

            return returnList;
        }
    }

    public class LinkedListNode
    {
        public  int data;

        public LinkedListNode Next;

        public LinkedListNode(int x)
        {
            this.data = x;
        }

        public void AddList(int x)
        {
            var mainList = this;

            while(mainList.Next != null)
            {
                mainList = mainList.Next;
            }

            mainList.Next = new LinkedListNode(x);
        }

    }