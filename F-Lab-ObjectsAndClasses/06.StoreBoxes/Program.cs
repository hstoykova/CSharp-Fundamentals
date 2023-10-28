/*
19861519 Dove 15 2.50
86757035 Butter 7 3.20
39393891 Orbit 16 1.60
37741865 Samsung 10 1000
end

48760766 Alcatel 8 100
97617240 Intel 2 500
83840873 Milka 20 2.75
35056501 SneakersXL 15 1.50
end

*/

namespace _06.StoreBoxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            List<Box> boxes = new List<Box>();

            while ((input = Console.ReadLine()) != "end")
            {
                string[] tokens = input.Split();
                string serialNumber = tokens[0];
                string itemName = tokens[1];
                int itemQuantity = int.Parse(tokens[2]);
                double itemPrice = double.Parse(tokens[3]);

                Item item = new Item(); //object
                item.Name = itemName;
                item.Price = itemPrice;

                Box box = new Box();
                box.SerialNumber = serialNumber;
                box.Item = item;
                box.Quantity = itemQuantity;

                boxes.Add(box);           
            }

            List<Box> sortedBoxes = boxes.OrderByDescending(box => box.PriceBox).ToList();

            foreach (Box box in sortedBoxes)
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${(box.Item.Price):F2}: {box.Quantity}");
                Console.WriteLine($"-- ${(box.PriceBox):F2}"); 
            }
        }
    }

    class Item
    {
        public string Name { get; set; }

        public double Price { get; set; }
    }

    class Box
    {
        public string SerialNumber { get; set; }

        public Item Item { get; set; }

        public double Quantity { get; set; }

        public double PriceBox
        {
            get
            {
                return Quantity * Item.Price;
            }

        }
    }
}