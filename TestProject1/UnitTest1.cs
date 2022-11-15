using StudentServiceLib;

namespace TestProject1
    
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ScoreIs9_LetterShouldBe_A()
        {
            Student s = new Student();
            s.Score = 9;
            char letter = s.getLetterScore();
            Assert.AreEqual('A', letter);
        }

        [TestMethod]
        public void ScoreIs7_LetterShouldBe_B()
        {
            Student s = new Student();
            s.Score = 7;
            char letter = s.getLetterScore();
            Assert.AreEqual('B', letter);
        }

        [TestMethod]
        public void ScoreIs6_LetterShouldBe_C()
        {
            Student s = new Student();
            s.Score = 6;
            char letter = s.getLetterScore();
            Assert.AreEqual('C', letter);
        }

        [TestMethod]
        public void ScoreIs5_LetterShouldBe_C()
        {
            Student s = new Student();
            s.Score = 5;
            char letter = s.getLetterScore();
            Assert.AreEqual('C', letter);
        }
    }
}