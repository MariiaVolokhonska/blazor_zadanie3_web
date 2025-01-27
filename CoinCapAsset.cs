public class CoinCapAsset{
    public string id{get;set;}
    public string rank{get;set;}
    public string symbol{get;set;}
    public string name{get;set;}
    public string supply{get;set;}
    public string maxSupply{get;set;}
    public string marketCapUSD{get;set;}
    public string volumeUSD24Hr{get;set;}
    public string priceUSD{get;set;}
    public string changePercent24Hr{get;set;}
    public string vwap24Hr{get;set;}
    public string IconUrl =>
 $"https://assets.coincap.io/assets/icons/{symbol?.ToLower()}@2x.png";
 
}