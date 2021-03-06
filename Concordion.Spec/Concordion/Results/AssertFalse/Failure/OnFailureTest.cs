﻿using System.Text;
using Concordion.NET.Integration;
using Concordion.Spec.Support;

namespace Concordion.Spec.Concordion.Results.AssertFalse.Failure
{
    [ConcordionTest]
    public class OnFailureTest
    {
        public bool isPalindrome(string s) 
        {
            return s == Reverse(s);
        }

        private string Reverse(string s)
        {
            var builder = new StringBuilder();

            for (int index = s.Length - 1; index >= 0; index--)
            {
                builder.Append(s[index]);
            }

            return builder.ToString();
        }

        public string render(string fragment)
        {
            return new TestRig()
                .WithFixture(this)
                .ProcessFragment(fragment)
                .GetOutputFragmentXML();
        }
    }
}
