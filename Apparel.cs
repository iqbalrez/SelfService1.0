namespace SelfService
{
    public abstract class Apparel
    {
        public string type;
        public string brand;
        public string size;
        public double price;
        public int stock;
        protected static int totalpcs;
        
        public string Show()
        {
            return this.type + " " + this.brand + " " + this.size + " " + this.price + " " + this.stock;
        }
        public static int Total(){
            return totalpcs;
        }
    }
    
}