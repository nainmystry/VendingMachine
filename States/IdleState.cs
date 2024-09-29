
public class IdleState : IState
{
    public IdleState()
    {
        Console.WriteLine("Machine in Idle state.");
    }

    public IdleState(VendingMachine machine)
    {
        Console.WriteLine("Machine in Idle state.");
        machine.setCoinList(new List<Coin>());
    }

    //Only Implement the methods usefull in this state.
    //For others give default behavior or throw error

    public void onClickInsertButton(VendingMachine machine)
    {
        machine.setVendingMachineState(new TransactionState());
    }

    public void updateInventory(VendingMachine machine, Item item, int codeNumber)
    {
        machine.getInventory().addItem(item, codeNumber);
    }

    public void chooseProduct(VendingMachine machine, int codeNumber)
    {
        throw new NotImplementedException("Click Insert Button");
    }

    public Item dispenseProduct(VendingMachine machine, int codeNumber)
    {
        throw new NotImplementedException("Product cannot be dispensed in current state");
    }

    public int getChange(int returnChangeAmount)
    {
        throw new NotImplementedException("Contact admin.");
    }

    public void insertCoin(VendingMachine machine, Coin coin)
    {
        throw new NotImplementedException("First Click Insert Button.");
    }

    public List<Coin> refundFullAmount(VendingMachine machine)
    {
        throw new NotImplementedException("Contact Admin.");
    }

    public void selectProduct(VendingMachine machine)
    {
        throw new NotImplementedException("First Click Insert Button.");
    }
}