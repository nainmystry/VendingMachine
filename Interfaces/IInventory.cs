public interface IInventory
{
    ItemShelf[] getInventory();
    
    void setInventory(ItemShelf[] inventory);

    void initialEmptyInventory();

    void addItem(Item item, int codeNumber);

    Item getItem(int codeNumber);

    void updateSoldOutItem(int codeNumber);
}