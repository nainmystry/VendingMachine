// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

void StartMachine()
{
    VendingMachine vendingMachine = new VendingMachine();
    try {

        Console.Write("|");
        Console.Write("filling up the inventory");
        Console.WriteLine("|");

        fillUpInventory(vendingMachine);
       // displayInventory(vendingMachine);

        Console.Write("|");
        Console.Write("clicking on InsertCoinButton");
        Console.WriteLine("|");

        IState vendingState = vendingMachine.getVendingMachineState();
        vendingState.onClickInsertButton(vendingMachine);

        vendingState = vendingMachine.getVendingMachineState();
        vendingState.insertCoin(vendingMachine, Coin.TWO);
        vendingState.insertCoin(vendingMachine, Coin.FIVE);
        // vendingState.insertCoin(vendingMachine, Coin.NICKEL);

        Console.Write("|");
        Console.Write("clicking on ProductSelectionButton");
        Console.WriteLine("|");
        vendingState.selectProduct(vendingMachine);

        vendingState = vendingMachine.getVendingMachineState();
        vendingState.chooseProduct(vendingMachine, 102);

       // displayInventory(vendingMachine);

    }
    catch (Exception e){
        displayInventory(vendingMachine);
    }
}

static void fillUpInventory(VendingMachine vendingMachine){
    ItemShelf[] slots = vendingMachine.getInventory().getInventory();
    for (int i = 0; i < slots.Length; i++) {
        Item newItem = new Item();
        if(i >=0 && i<3) {
            newItem.setType(ItemType.COKE);
            newItem.setPrice(7);
        }else if(i >=3 && i<5){
            newItem.setType(ItemType.WATER);
            newItem.setPrice(9);
        }else if(i >=5 && i<7){
            newItem.setType(ItemType.JUICE);
            newItem.setPrice(13);
        }else if(i >=7 && i<10){
            newItem.setType(ItemType.SODA);
            newItem.setPrice(7);
        }
        slots[i].setItem(newItem);
        slots[i].setSoldOut(false);
    }
}

void displayInventory(VendingMachine vendingMachine){

    ItemShelf[] slots = vendingMachine.getInventory().getInventory();
    for (int i = 0; i < slots.Length; i++) {

        Console.WriteLine("CodeNumber: " + slots[i].getCode() +
                " Item: " + slots[i].getItem().getType().ToString() +
                " Price: " + (int)slots[i].getItem().getPrice() +
                " isAvailable: " + !slots[i].isSoldOut());
    }
}

StartMachine();