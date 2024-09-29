public class Item
{
    ItemType _itemType;
    int _price;

    public ItemType getType()
    {
        return _itemType;
    }

    public void setType(ItemType type)
    {
        _itemType = type;
    }

    public int getPrice(){
        return _price;
    }

    public void setPrice(int price){
        _price = price;
    }
}
