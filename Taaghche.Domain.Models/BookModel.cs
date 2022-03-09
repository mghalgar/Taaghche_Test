using System;
using System.Collections.Generic;

namespace Taaghche.Domain.Models
{
    

    public class Rate
    {
        public double Value { get; set; }
        public int Count { get; set; }
    }

    public class RateDetail
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public double Point { get; set; }
    }

    public class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Type { get; set; }
        public string Slug { get; set; }
    }

    public class File
    {
        public int Id { get; set; }
        public int Size { get; set; }
        public int Type { get; set; }
        public int BookId { get; set; }
        public int SequenceNo { get; set; }
        public string Title { get; set; }
    }

    public class Label
    {
        public int TagID { get; set; }
        public string Tag { get; set; }
        public string Slug { get; set; }
    }

    public class Category
    {
        public int Id { get; set; }
        public int Parent { get; set; }
        public string Title { get; set; }
        public string Slug { get; set; }
        public string Icon { get; set; }
    }

    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int SourceBookId { get; set; }
        public int CanonicalId { get; set; }
        public string Description { get; set; }
        public string HtmlDescription { get; set; }
        public int PublisherID { get; set; }
        public string PublisherSlug { get; set; }
        public double Price { get; set; }
        public int NumberOfPages { get; set; }
        public double Rating { get; set; }
        public List<Rate> Rates { get; set; }
        public List<RateDetail> RateDetails { get; set; }
        public string Sticker { get; set; }
        public bool HasTemporaryOff { get; set; }
        public int BeforeOffPrice { get; set; }
        public string OffText { get; set; }
        public string PriceColor { get; set; }
        public bool IsRtl { get; set; }
        public bool ShowOverlay { get; set; }
        public int PhysicalPrice { get; set; }
        public string ISBN { get; set; }
        public string PublishDate { get; set; }
        public int Destination { get; set; }
        public string Type { get; set; }
        public string RefId { get; set; }
        public string CoverUri { get; set; }
        public string ShareUri { get; set; }
        public string ShareText { get; set; }
        public string Publisher { get; set; }
        public List<Author> Authors { get; set; }
        public List<File> Files { get; set; }
        public List<Label> Labels { get; set; }
        public List<Category> Categories { get; set; }
        public bool SubscriptionAvailable { get; set; }
        public DateTime NewsItemCreationDate { get; set; }
        public int State { get; set; }
        public bool Encrypted { get; set; }
        public double CurrencyPrice { get; set; }
        public double CurrencyBeforeOffPrice { get; set; }
    }

    public class LatestReply
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public bool VerifiedAccount { get; set; }
        public string Nickname { get; set; }
        public string ProfileImageUri { get; set; }
        public int BookId { get; set; }
        public string BookCoverUri { get; set; }
        public string BookName { get; set; }
        public string CreationDate { get; set; }
        public double Rate { get; set; }
        public int RepliesCount { get; set; }
        public int LikeCount { get; set; }
        public int DislikeCount { get; set; }
        public string Comment { get; set; }
        public bool IsLiked { get; set; }
        public bool IsDisliked { get; set; }
        public List<object> RateDetails { get; set; }
        public int Recommendation { get; set; }
    }

    public class CommentModel
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public bool VerifiedAccount { get; set; }
        public string Nickname { get; set; }
        public string ProfileImageUri { get; set; }
        public int BookId { get; set; }
        public string BookCoverUri { get; set; }
        public string BookType { get; set; }
        public string BookName { get; set; }
        public string CreationDate { get; set; }
        public double Rate { get; set; }
        public List<LatestReply> LatestReplies { get; set; }
        public int RepliesCount { get; set; }
        public int LikeCount { get; set; }
        public int DislikeCount { get; set; }
        public string Comment { get; set; }
        public bool IsLiked { get; set; }
        public bool IsDisliked { get; set; }
        public List<RateDetail> RateDetails { get; set; }
        public int Recommendation { get; set; }
    }

   

    public class BookData
    {
        public List<Book> Books { get; set; }
        public int Layout { get; set; }
        public bool ShowPrice { get; set; }
    }

    public class List
    {
        public int Type { get; set; }
        public int Value { get; set; }
    }

    public class Filters
    {
        public List<List> List { get; set; }
        public string RefId { get; set; }
    }

    public class Destination
    {
        public int Type { get; set; }
        public int Order { get; set; }
        public int NavigationPage { get; set; }
        public int OperationType { get; set; }
        public int BookId { get; set; }
        public string PageTitle { get; set; }
        public Filters Filters { get; set; }
    }

    public class BackgroundConfig
    {
        public int Style { get; set; }
    }

    public class RelatedBook
    {
        public int Type { get; set; }
        public string Title { get; set; }
        public int BackgroundStyle { get; set; }
        public BookData BookData { get; set; }
        public Destination Destination { get; set; }
        public BackgroundConfig BackgroundConfig { get; set; }
    }

    public class Data
    {
        public string Quote { get; set; }
        public int StartAtomId { get; set; }
        public int EndAtomId { get; set; }
        public int ChapterIndex { get; set; }
        public int EndOffset { get; set; }
        public int StartOffset { get; set; }
    }

    public class Quote
    {
        public string Id { get; set; }
        public Data Data { get; set; }
        public string Description { get; set; }
        public int LikeCount { get; set; }
        public int BookId { get; set; }
        public int AccountId { get; set; }
        public int CommentCount { get; set; }
        public string CreationDate { get; set; }
        public DateTime Date { get; set; }
        public bool ShowComment { get; set; }
        public string CoverUri { get; set; }
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public string PublisherName { get; set; }
        public string ProfileImageUri { get; set; }
        public string Nickname { get; set; }
    }

    public class BookModel
    {
        public Book Book { get; set; }
        public List<CommentModel> Comments { get; set; }
        public int CommentsCount { get; set; }
        public List<RelatedBook> RelatedBooks { get; set; }
        public string ShareText { get; set; }
        public List<Quote> Quotes { get; set; }
        public int QuotesCount { get; set; }
        public bool HideOffCoupon { get; set; }
    }


}
