namespace GradeBook.Tests
{
    using System;
    using Xunit;

    public delegate string WriteLogDelegate(string logMessage);

    public class TypeTests
    {
        int count = 0; 

        [Fact]
        public void WriteLogDelegateCanPointToMethod()
        {
            WriteLogDelegate log = ReturnMessage; // new WriteLogDelegate(ReturnMessage);
            log += ReturnMessage;
            log += IncrementCount;

            var result = log("Hello!");
            Assert.Equal(3, count);
        }

        string IncrementCount(string message)
        {
            count++;
            return message.ToLower();
        }

        string ReturnMessage(string message)
        {
            count++;
            return message;
        }

        [Fact]
        public void StringsBehaveLikeValueTypes()
        {
            string name = "Tosa";
            var upper = MakeUppercase(name);

            Assert.Equal("Tosa", name);
            Assert.Equal("TOSA", upper);
        }

        private string MakeUppercase(string parameter)
        {
            return parameter.ToUpper();
        }

        [Fact]
        public void ValueTypeCanPassByRef()
        {
            var x = GetInt();
            SetIntByRef(ref x);

            Assert.Equal(42, x);
        }
        private void SetIntByRef(ref int z)
        {
            z = 42;
        }

        [Fact]
        public void ValueTypeAlsoPassByValue()
        {
            var x = GetInt();
            Assert.Equal(3, x);

            SetInt(x);
            Assert.Equal(3, x);
        }

        private void SetInt(int x)
        {
            x = 42;
        }

        private int GetInt()
        {
            return 3;
        }

        [Fact]
        public void CSharpCanPassByRefUsingOut()
        {
            var book1 = GetBook("Book 1");
            GetBookSetNameByReferenceUsingOut(out book1, "New Name");

            Assert.Equal("New Name", book1.Name);
        }
        private void GetBookSetNameByReferenceUsingOut(out Book book, string name)
        {
            book = new Book(name);
        }

        [Fact]
        public void CSharpCanPassByRef()
        {
            var book1 = GetBook("Book 1");
            GetBookSetNameByReference(ref book1, "New Name");

            Assert.Equal("New Name", book1.Name);
        }

        private void GetBookSetNameByReference(ref Book book, string name)
        {
            book = new Book(name);
        }

        [Fact]
        public void CSharpIsPassByValue()
        {
            var book1 = GetBook("Book 1");
            GetBookSetName(book1, "New Name");

            Assert.Equal("Book 1", book1.Name);
        }

        private void GetBookSetName(Book book, string name)
        {
            book = new Book(name);
        }

        [Fact]
        public void CanSetNameFromReference()
        {
            var book1 = GetBook("Book 1");
            Assert.Equal("Book 1", book1.Name);

            SetName(book1, "New Name");
            Assert.Equal("New Name", book1.Name);
        }

        private void SetName(Book book, string name)
        {
            book.Name = name;
        }

        [Fact]
        public void GetBookReturnsDifferentObjects()
        {
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");

            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);
            Assert.NotSame(book1, book2);
        }

        [Fact]
        public void TwoVarsCanReferenceSameObject()
        {
            var book1 = GetBook("Book 1");
            var book2 = book1;

            Assert.Same(book1, book2);
            Assert.True(Object.ReferenceEquals(book1, book2));
        }

        Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}
