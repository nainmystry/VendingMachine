public interface IVendingMachine
{
    IState getVendingMachineState();

    void setVendingMachineState(IState machineState);

    IInventory getInventory();

    void setInventory(Inventory inventory);

    List<Coin> getCoinList();

    void setCoinList(List<Coin> coins);
}