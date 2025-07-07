namespace Library.ApplicationCore.Entities;

public class BookItem
{
    public int Id { get; set; }
    public int BookId { get; set; }
    public DateTime AcquisitionDate { get; set; }
    public string? Condition { get; set; }
    public Book? Book { get; set; }

    public static bool IsAvailable(int bookItemId, List<Loan> loans)
    {
        // Um exemplar está disponível se não há empréstimo em aberto (ReturnDate == null)
        return !loans.Any(l => l.BookItemId == bookItemId && l.ReturnDate == null);
    }
}
