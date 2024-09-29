
public class DispenseState : IState
{
    public DispenseState(VendingMachine machine, int codeNumber)
    {
        dispenseProduct(machine, codeNumber);
    }

    public void chooseProduct(VendingMachine machine, int codeNumber)
    {
        throw new InvalidOperationException();
    }

    public Item dispenseProduct(VendingMachine machine, int codeNumber)
    {
        Item item = machine.getInventory().getItem(codeNumber);
        machine.getInventory().updateSoldOutItem(codeNumber);
        machine.setVendingMachineState(new IdleState(machine));
        Console.WriteLine("Product Dispensed.");
        return item;
    }

    public int getChange(int returnChangeAmount)
    {
        throw new InvalidOperationException();
    }

    public void insertCoin(VendingMachine machine, Coin coin)
    {
        throw new InvalidOperationException();
    }

    public void onClickInsertButton(VendingMachine machine)
    {
        throw new InvalidOperationException();
    }

    public List<Coin> refundFullAmount(VendingMachine machine)
    {
        throw new InvalidOperationException();
    }

    public void selectProduct(VendingMachine machine)
    {
        throw new InvalidOperationException();
    }

    public void updateInventory(VendingMachine machine, Item item, int codeNumber)
    {
        throw new InvalidOperationException();
    }
}