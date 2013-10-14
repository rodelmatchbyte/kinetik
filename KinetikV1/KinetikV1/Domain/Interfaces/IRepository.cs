using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KinetikV1.Domain.Models;

namespace KinetikV1.Domain.Interfaces
{
    public interface IRepository
    {
        // MySqlRepository
        List<Offer> Offer();
        Offer Offer(int id);
        void AddOffer(Offer offer);
        void DeleteOffer(int id);
        void UpdateOffer(Offer offer);

        // ShopifyRepository
        void AddShopifyTransaction(string json);
        string GetShopifyTransaction(string checkoutId);
        List<string> GetShopifyTransactions();
        
        // AccountRepository
        void AddAccount(Account account);
        void DeleteAccount(long id);
        void UpdateAccount(Account account);
        List<Account> GetAccounts();
        Account GetAccount(long id);
        List<Account> GetAccountsByName(string name);

        // SettingRepository
        string GetSettingValue(string key);
        void SetSettingValue(string key, string value);

        // SessionRepository
        string RegisterSession(Account account);
        void DeleteSession(Account account);
        string GetSession(Account account);
    }
}