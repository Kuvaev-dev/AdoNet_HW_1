namespace AdoNet_HW_1
{
    public struct Food
    {
        public string name;
        public bool type;
        public string color;
        public int calory;
    }
    class DB_Logic
    {
        public bool Button_Save(Food food)
        {
            return DB_Model.Write_DB(food);
        }
    }
}
