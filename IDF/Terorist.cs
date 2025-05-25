
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Xml.Linq;


public class Terorist
{
    public string name;
    public int rank;
    public bool status;
    public string weapon;
    private Hamas Hamas;
    public Terorist(string name, int rank, bool status, string weapon)
    {
        this.name = name;
        this.rank = rank;
        this.status = status;
        this.weapon = weapon;
    }
    public void Produce_alone(Hamas hamas)
    {
        hamas.add_terorist(this);

    }
    //public void creator(List<Terorist> list_terorist)
    //{
    //   
    //    
}








