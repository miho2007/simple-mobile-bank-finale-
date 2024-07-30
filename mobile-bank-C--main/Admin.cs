using System;
using System.Collections.Generic;

public class Admin
{
    public int ID { get; set; } = 1111111111;
    public UserType UserType { get; set; }

    private List<User> _users;
    private List<Transaction> _transactions;

    public Admin()
    {
        _users = new List<User>();
        _transactions = new List<Transaction>();
        UserType = UserType.Admin;
    }

    public void AddUser(User user)
    {
        _users.Add(user);
    }

    public void SeeAllUsers()
    {
        foreach (var user in _users)
        {
            Console.WriteLine($"ID: {user.ID}, Name: {user.Name}, UserType: {user.UserType}");
        }
    }

    public void UpdateUser(int userId, User updatedUser)
    {
        var user = _users.Find(u => u.ID == userId);
        if (user!= null)
        {
            user.Name = updatedUser.Name;
            user.UserType = updatedUser.UserType;
        }
    }

    public void DeleteUser(int userId)
    {
        var user = _users.Find(u => u.ID == userId);
        if (user!= null)
        {
            _users.Remove(user);
        }
    }

    public void SeeTransactions()
    {
        foreach (var transaction in _transactions)
        {
            Console.WriteLine($"ID: {transaction.ID}, UserID: {transaction.UserID}, Amount: {transaction.Amount}");
        }
    }
}



public enum UserType
{
    Admin,
    
    User
}