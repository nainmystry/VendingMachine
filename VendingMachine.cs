public class VendingMachine : IVendingMachine
{
    private IState _machineState;
    private IInventory _inventory;
    private List<Coin> _coinList;

    public VendingMachine()
    {
        _machineState = new IdleState();
        _inventory = new Inventory(10);
        _coinList = new List<Coin>();
    }

    public List<Coin> getCoinList()
    {
        return _coinList;
    }

    public IInventory getInventory()
    {
        return _inventory;
    }

    public IState getVendingMachineState()
    {
        return _machineState;
    }

    public void setCoinList(List<Coin> coins)
    {
        _coinList = coins;
    }

    public void setInventory(Inventory inventory)
    {
        _inventory = inventory;
    }

    public void setVendingMachineState(IState machineState)
    {
        _machineState = machineState;
    }
}