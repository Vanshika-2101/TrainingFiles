using MyApp;
namespace GradeTest
{
    public class GradeCalcTests
    {
        private GradeCalc _calc { get; set; } = null;

        [SetUp]
        public void Setup()
        {
            _calc = new GradeCalc();

        }

        [TestCase(90)]
        [TestCase(91)]
        [TestCase(99)]
        [TestCase(100)]
        [TestCase(95)]

        public void GetGradeByPercentage_Test(int data)
        {
            var percentage = data;    //Assign
            var grade = _calc.GetGradeByPercentage(percentage);     //Act
            Assert.AreEqual("A", grade);        //Assert
        }

        [TestCase(0)]
        [TestCase(80)]
        [TestCase(75)]
        [TestCase(35)]
        [TestCase(110)]

        public void GetGradeByPercentage_NegativeTest(int data)
        {
            var percentage = data;    //Assign
            var grade = _calc.GetGradeByPercentage(percentage);     //Act
            Assert.AreNotEqual("A", grade);        //Assert
        }
    }
}