using System;
using Xunit;
using Assignment_6;
using System.Collections.Generic;
using Assignment_6.workflow;
using Assignment_6.activities;
using Assignment_6.interfaces;
using System.Diagnostics.CodeAnalysis;
using System.Collections;

namespace Assignment_6.tests
{
    [ExcludeFromCodeCoverage]
    public class UnitTest1
    {
        [Theory]
        [MemberData(nameof(RegisterActivityData))]
        public void RegisterActivity_VariousValuesPassedInAndAddedVariableTimes_ReturnsValidCount(int expectedResult, int iterationCount)
        {
            var sut = new WorkFlow();

            for (var index = 0; index < iterationCount; index++)
            {
                sut.RegisterActivity(new EmailNotificationActivity(3));
                sut.RegisterActivity(new InitializeDatabaseActivity(2));
                sut.RegisterActivity(new VideoUploadActivity(1));
                sut.RegisterActivity(new ThirdPartyNotificationActivity(4));
                sut.RegisterActivity(null);
            }

            var actual = sut.CountActivities();

            Assert.Equal(expectedResult, actual);
        }

        public static IEnumerable<object[]> RegisterActivityData => new List<object[]>
        {

            new object[] {4, 1},
            new object[] {8, 2},
            new object[] {12, 3}

        };
    }
}
