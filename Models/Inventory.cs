public class Inventory : IInventory
{
    ItemShelf[] inventory = null;
    public Inventory(int itemCount)
    {
        inventory = new ItemShelf[itemCount];
        initialEmptyInventory();
    }

    public void addItem(Item item, int codeNumber)
    {
        foreach (ItemShelf itemShelf in inventory)
        {
            if(itemShelf.getCode() == codeNumber)
            {
                if(itemShelf.isSoldOut()){
                    itemShelf.setItem(item);
                    itemShelf.setSoldOut(false);
                }
                else{
                    throw new Exception("Item Present.");
                }
            }
        }
    }

    public ItemShelf[] getInventory()
    {
        return inventory;
    }

    public Item getItem(int codeNumber)
    {
        foreach (ItemShelf item in inventory)
        {
            if(item.getCode() == codeNumber){
                if(item.isSoldOut()){     
                    throw new Exception("Item not available.");           
                }
                else{
                    return item.getItem();
                }
            }
        }

        throw new Exception("Invalid Code.");
    }

    public void initialEmptyInventory()
    {
        int startCode = 101;
        for (int i = 0; i < inventory.Length; i++)
        {
            ItemShelf space = new ItemShelf();
            space.setCode(startCode);
            space.setSoldOut(true);
            inventory[i] = space;
            startCode++;
        }
    }

    public void setInventory(ItemShelf[] inventory)
    {
        this.inventory = inventory;
    }

    public void updateSoldOutItem(int codeNumber)
    {
        foreach (ItemShelf itemShelf in inventory) {
            if (itemShelf.getCode() == codeNumber) {
                itemShelf.setSoldOut(true);
            }
        }
    }
}