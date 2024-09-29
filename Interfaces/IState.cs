public interface IState
{
    void onClickInsertButton(VendingMachine machine);

    void selectProduct(VendingMachine machine);
    
    void insertCoin(VendingMachine machine, Coin coin);
    
    void chooseProduct(VendingMachine machine, int codeNumber);
    
    int getChange(int returnChangeAmount);
    
    Item dispenseProduct(VendingMachine machine, int codeNumber);
    
    List<Coin> refundFullAmount(VendingMachine machine);
    
    void updateInventory(VendingMachine machine, Item item, int codeNumber); 

}