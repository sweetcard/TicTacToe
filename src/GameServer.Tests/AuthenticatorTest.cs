﻿using System;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace GameServer.Tests
{
    public class AuthenticatorTest : IClassFixture<MongoDbStorageFixture>
    {
        /*
        [Fact]
        public async Task Test_AuthenticateAsync_FirstCreate_Succeed()
        {
            var ret = await Authenticator.AuthenticateAsync("test", "1234");
            Assert.Equal("test", ret);
        }

        [Fact]
        public async Task Test_AuthenticateAsync_SecondMatch_Succeed()
        {
            var ret = await Authenticator.AuthenticateAsync("test", "1234");
            var ret2 = await Authenticator.AuthenticateAsync("test", "1234");
            Assert.Equal("test", ret);
            Assert.Equal("test", ret2);
        }

        [Fact]
        public async Task Test_AuthenticateAsync_SecondUnmatch_Fail()
        {
            var ret = await Authenticator.AuthenticateAsync("test", "1234");
            var ret2 = await Authenticator.AuthenticateAsync("test", "123");
            Assert.Equal("test", ret);
            Assert.Equal(string.Empty, ret2);
        }
        */
    }
}
