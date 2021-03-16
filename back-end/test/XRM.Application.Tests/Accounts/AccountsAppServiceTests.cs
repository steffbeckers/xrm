using Shouldly;
using System;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Validation;
using XRM.Accounts.Dto;
using Xunit;

namespace XRM.Accounts
{
    public class AccountsAppServiceTests : XRMApplicationTestBase
    {
        private readonly IAccountsAppService _accountsAppService;

        public AccountsAppServiceTests()
        {
            _accountsAppService = GetRequiredService<IAccountsAppService>();
        }

        [Fact]
        public async Task Should_Get_List_Of_Accounts()
        {
            // Arrange

            // Act
            var result = await _accountsAppService.GetListAsync(new PagedAndSortedResultRequestDto());

            // Assert
            result.TotalCount.ShouldBeGreaterThan(0);
            result.Items.ShouldContain(x => x.Name == "Steff Beckers");
        }

        [Fact]
        public async Task Should_Create_A_Valid_Account()
        {
            // Act
            var result = await _accountsAppService.CreateAsync(
                new CreateAccountDto()
                {
                    Name = "Test account 1"
                }
            );

            // Assert
            result.Id.ShouldNotBe(Guid.Empty);
            result.Name.ShouldBe("Test account 1");
        }

        [Fact]
        public async Task Should_Not_Create_An_Account_Without_Name()
        {
            // Act
            var exception = await Assert.ThrowsAsync<AbpValidationException>(async () =>
            {
                await _accountsAppService.CreateAsync(
                    new CreateAccountDto()
                    {
                        Name = string.Empty,
                        Website = "https://testaccountwithoutname.com"
                    }
                );
            });

            exception.ValidationErrors.ShouldContain(x => x.MemberNames.Any(y => y == "Name"));
        }
    }
}
