
public class TransactionState : IState
{
    public TransactionState()
    {
        Console.WriteLine("In Transaction state");
    }

    public void insertCoin(VendingMachine machine, Coin coin)
    {
        machine.getCoinList().Add(coin);
        Console.WriteLine("Coin Added.");
    }

    public void onClickInsertButton(VendingMachine machine)
    {
        return;
    }

    public List<Coin> refundFullAmount(VendingMachine machine)
    {
        machine.setVendingMachineState(new IdleState());
        return machine.getCoinList();
    }

    public void selectProduct(VendingMachine machine)
    {
        machine.setVendingMachineState(new SelectionState());
    }

    public void chooseProduct(VendingMachine machine, int codeNumber)
    {
        throw new NotImplementedException("select product selection.");
    }

    public Item dispenseProduct(VendingMachine machine, int codeNumber)
    {
        throw new NotImplementedException("select product");
    }

    public int getChange(int returnChangeAmount)
    {
        throw new NotImplementedException("Invalid Operation.");
    }

    public void updateInventory(VendingMachine machine, Item item, int codeNumber)
    {
        throw new NotImplementedException("Invalid Operation.");
    }
}