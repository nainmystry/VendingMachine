public class ItemShelf
{
    int _itemCode;
    Item _item;
    bool _soldOut;

    public int getCode(){
        return _itemCode;
    }

    public void setCode(int code){
        _itemCode = code;
    }

    public Item getItem(){
        return _item;
    }

    public void setItem(Item item){
        _item = item;
    }

    public bool isSoldOut(){
        return _soldOut;
    }    

    public void setSoldOut(bool soldOut){
        _soldOut = soldOut;
    }
}