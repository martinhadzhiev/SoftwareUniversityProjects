using System;
using NUnit.Framework;

[TestFixture]
public class DummyTests
{
    [Test]
    public void DummyLosesHealthIfAttacked()
    {
        Dummy dummy = new Dummy(10, 10);

        dummy.TakeAttack(1);

        Assert.AreEqual(9, dummy.Health, "Dummy didn't loose health.");
    }

    [Test]
    public void DeadDummyThrowsExceptionIfAttacked()
    {
        Dummy dummy = new Dummy(0, 0);

        string exceptionMessage = Assert.Throws<InvalidOperationException>(() => dummy.TakeAttack(1)).Message;

        Assert.AreEqual("Dummy is dead.", exceptionMessage, "Exception messages are not equal!");
    }

    [Test]
    public void DeadDummyGivesXp()
    {
        Dummy dummy = new Dummy(0, 10);

        Assert.AreEqual(10, dummy.GiveExperience(), "Dead dummy does not give XP!");
    }

    [Test]
    public void AliveDummyCannotGiveXp()
    {
        Dummy dummy = new Dummy(1, 10);

        string exceptionMessage = Assert.Throws<InvalidOperationException>(() => dummy.GiveExperience()).Message;

        Assert.AreEqual("Target is not dead.", exceptionMessage, "Exception message are not equal!");
    }
}