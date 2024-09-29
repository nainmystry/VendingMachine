
using Microsoft.VisualBasic;

public class SelectionState : IState
{
    public SelectionState()
    {
        Console.WriteLine("Selection State");    
    }

    public void chooseProduct(VendingMachine machine, int codeNumber)
    {
        Item item = machine.getInventory().getItem(codeNumber);

        int amountReceived = 0;
        foreach (Coin coin in machine.getCoinList())
        {
            amountReceived += (int)coin;
        }

        if(amountReceived < item.getPrice())
        {
            Console.WriteLine("Insufficient amount.");   
            refundFullAmount(machine); 
            throw new Exception("Insufficient amount.");
        }
        else{
            if(amountReceived > item.getPrice())
            {
                getChange(amountReceived - item.getPrice());
            }
            machine.setVendingMachineState(new DispenseState(machine, codeNumber));
        }
    }

    public Item dispenseProduct(VendingMachine machine, int codeNumber)
    {
        throw new InvalidOperationException();
    }

    public int getChange(int returnChangeAmount)
    {
        return returnChangeAmount;
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
        machine.setVendingMachineState(new IdleState(machine));
        return machine.getCoinList();
    }

    public void selectProduct(VendingMachine machine)
    {
        return;
    }

    public void updateInventory(VendingMachine machine, Item item, int codeNumber)
    {
        throw new InvalidOperationException();
    }
}