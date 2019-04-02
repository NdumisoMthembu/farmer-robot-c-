using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Farm_Walker.Models;
using System.Collections.Generic;
using System.Collections;



namespace Robot.Test
{
    [TestClass]
    public class RobotTest
    {
        [TestMethod]
        public void TestCmd()
        {
            string[] comms = new string[] { "N4", "E2", "S2", "W4" };
            List<string> cmds = new List<string>();
            cmds.AddRange(new string[] { "N4", "E2", "S2", "W4" });
            int expectedValidMoves = 11;
            int actual = new Commander(cmds).Run();
            Assert.AreEqual(expectedValidMoves, actual);
        }

   
    }
}
