﻿public class LedgerEntry407
{
    public int Id { get; set; } // Assuming an ID for each entry
    public DateOnly Date { get; set; }

    public int FormNumber { get; set; }

    public string Remarks { get; set; }




    //Current Year Field

    public int CurrentQuantity { get; set; }
    public decimal CurrentIncomeRate { get; set; }
    public decimal CurrentIncomeAmount { get; set; }

    // Income fields
    public int IncomeQuantity { get; set; }
    public decimal IncomeRate { get; set; }
    public decimal IncomeAmount { get; set; }

    // Expenditure fields
    public int ExpenditureQuantity { get; set; }
    public decimal ExpenditureRate { get; set; }
    public decimal ExpenditureAmount { get; set; }

    // Pending fields
    public EntryType EntryType { get; set; }

    public int PendingQuantity { get; set; }
    public decimal PendingRate { get; set; }
    public decimal PendingAmount { get; set; }

    public int Total { get; set; }



    // Prepared by

}

public enum EntryType
{
    Current,
    StoreEntry,
    Expenditure,
    Pending
}

//Enum is a special class that represents a group of cons