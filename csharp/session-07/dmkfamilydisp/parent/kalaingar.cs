namespace dmkfamilydisp{

class Kalaingar{
    string politicalpartyname, newspaper, house,productioncompany;
    string [] tvchannel = {"kalaingartv", "Sirippoli", "chithiram", "isaiyaruvi", "kalaingar news"};
    public Kalaingar(){
        politicalpartyname="DMK";
        newspaper="Murasoli";
        house="gopalapuram house";
        productioncompany="Red Giant Movie pvt ltd";
        
    }

    public string getpoliticalpartyname(){
        return politicalpartyname;
    }

      public string getNewspaper(){
        return newspaper;
    }

     public string getHouse(){
        return house;
    }

    public string getProductioncompany(){
        return productioncompany;
    }
    
    

}



}