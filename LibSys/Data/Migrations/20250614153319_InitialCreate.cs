using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LibSys.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("a9631293-7513-495b-a785-f0365a635d88"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("bd510fa3-a160-4fe8-9821-8f987c68bebc"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0153d434-ef3a-40f1-8533-907dec68d164"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("04409baa-150f-41c7-a377-0b4604feb78b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0b95f4be-e662-4bdf-b2d4-6b0f4afd8764"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0dd4f40d-7d4d-4c48-8f76-6617c06837af"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1888c887-81e1-4046-b280-72baa3d22ec7"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1b54954e-a65f-4b3e-a055-e512a94ba937"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1bcbf03f-169b-4e00-8fe0-eb4ed205460f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1c283061-3f71-4237-993d-cade422877ed"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1efc4ca5-f1b4-480e-9609-8288fd159293"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1f36fe2f-3e7b-48d0-b3cb-836839b2f753"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2155809f-8d7b-4b54-b718-f24d0ab3ddec"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("22299b68-0f32-4a1f-98b3-fdca4e2cab03"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("22f2196a-e666-43f4-856c-f79f566b3347"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2959712c-0ae7-4625-9773-0c08deadd084"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2a534249-c38d-4280-8068-2102b4124406"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2a6e605b-1265-4720-8f70-81e1dae8825c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2d3287f3-fdf1-4e70-b2f6-3c7efec08de4"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("32d08c81-aa38-48a0-94ec-f6627d14fc1c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("36740fc1-c198-4283-b984-42bb905a8a8e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("418d1f60-40b6-4ca7-9beb-83efdf647117"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4e651f9f-8820-4fd2-afb8-1379b242d797"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4fa6c3f0-8eb8-4fea-87e9-a6e254a0c7b9"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("527a3be6-1539-4522-9a4a-ab43cc9785d8"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("5434d5f9-59e9-45ae-b60e-def591915f9e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("596dbd64-2d93-40b0-91a6-e8b55618b979"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("59dec810-5a4e-481e-b6d8-1e4e979f6d82"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("5efba376-cc0b-4eb4-b5e6-705c7c5aa3d2"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("5f49739f-50cf-479a-a1f5-03b1ee1d4d0b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("683b8066-c9ad-4f48-b19d-40f240a455a7"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("68da4603-2f36-49bf-aef2-6d5620877571"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("7304d5b9-1639-4103-9e30-a091284be2c9"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("7645beea-eefa-482a-9661-b3a272029161"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("76abbd49-55ef-4c31-8d72-9e95244b699d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("78ac340c-2c1b-45e6-80be-0e38a450adcf"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("809163f6-0376-4882-bf72-8af1c3a28a53"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("87a00a22-42fa-4c40-93e3-6ef37ffa757f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("87ea4b18-ae43-4df2-988e-0475c640b174"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8f68c8c3-f03d-4d84-9e66-a7be4283601f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("944164c6-b86f-41b7-97d6-f743c2b92443"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("959ce6b3-9571-46b3-9353-c260f856b049"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("97072cef-9bcd-4265-ba30-0a0fd78c6436"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("98b492ed-d956-4d8c-9ad3-c3e2181d9f97"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9d50d65d-dec7-4409-8991-a0472acd68b9"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9e8d0c3a-4988-4b86-8da6-0ef8d84df9cd"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a0c9f9d3-8915-41ab-a47c-c951f9c330ec"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a3c52fd3-1622-4761-ad7a-b87ab4d693d8"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a5545a5d-c0ba-4018-8a7f-ef2171d3bd19"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a5bd34c9-cad1-4cdd-8d4b-81bda92ec2c8"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a6a6d974-5335-43d8-82dc-ddd5569ef9bd"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a8281dc2-5a2e-4ef9-a8b1-be6f197e59f0"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a8344ecf-a6b7-44b6-968f-3be73b62bfcf"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b1987401-f716-4f7a-8435-c677e29d8f4b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b6d81bdc-ec66-408b-bf17-bab396968af8"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b8a0724b-9651-4ac7-9eee-f46e30b14850"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("bb1ab2a2-abf2-459e-814b-e6a828db882a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("bcee4c61-51c3-49a8-ac8e-03dd5f970ec8"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c28fdcfc-328c-4724-9eaf-6b5e094c12e7"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c39a4265-485c-45c5-ab7b-1dadb839c19f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("cb801696-263e-4740-957a-ce024c27b4cf"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d09c1bde-86f3-4729-9fda-b2d32ea4f432"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d962a2bc-7dc6-431c-a778-0aa2853ce979"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("da3e3e65-83b8-4cee-95f3-429e6a5c5c3d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("de13e8a3-2d58-45f5-baa4-ffccbb8f11d8"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e0557675-d411-4161-b28e-05e14d61bb76"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e0824375-1ad0-4a96-9dac-a71c7017773d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e5331303-2952-42e5-960f-47a82e32c697"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e9e5fd26-1c25-40ef-a676-5e23456f187f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ea14453c-9f94-4d0e-9b93-b2f5b9dbc8c2"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("edc5d704-e409-4610-b79e-e69136e325d8"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f16077b4-f607-4fd0-9c39-4c0af2282777"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f1bd67fb-6ff2-47bf-a685-e6585ed593c2"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("fad1f62a-68a2-4d53-b70a-5af8a6d2640b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("fe176798-19cb-4e13-81a0-4ca6336e8aa5"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("05b4f074-d43b-44c4-bfed-a35ad8d64470"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("0a0fb03a-f762-472f-9741-714cc55d5911"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("1aa231bd-a902-43e9-9858-28111ff56ccb"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("2423e7e9-292e-48ce-8d52-b87d32c4e4ce"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("2803211d-ad45-4e57-aa5a-b61f54dc2e29"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("37aecbef-1ece-4ad2-b02f-4deb3e7672b1"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("408fc73b-ecf0-48aa-9f6e-2a71d8eb2978"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("48126097-ab80-4606-9f3a-b3e1c4a09bb2"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("59ff84ab-a5e5-4086-bbda-4b20c6723c48"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("5a1830fd-9167-4069-98c9-1a633fa72ca1"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("5f2b17b0-42d8-4168-a87b-619263f7f381"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("726a1619-a8e7-4c2e-9482-db30c0cb9390"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("91b18133-9de1-4b7c-9e89-973016d5c9d4"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("91fd4ad7-ff72-49e8-91bc-2593b99f3017"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("aef1dca7-5428-4bcd-b774-3a7efd0d0851"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("b7cfbb28-08f0-4170-823a-046e37875bbe"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("bc29121f-7542-4ac3-a877-2c1b15007430"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("cc6e68ad-9c4a-4627-888e-c271aabadbb4"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("d1263a07-dec9-4991-884d-5bb442d90bfa"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("da2dbd96-59ef-47a8-8fc1-a881cc999e88"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("dbb39616-aeb6-455c-83c2-8df7202f9a9a"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("ec2fc5b0-177a-4453-9e36-95836dedcc01"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("ed0d3401-202a-4573-8102-b8da6a560f44"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("ef0482f7-e1fc-46cf-914d-63e4ab6aa375"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("ef595e45-f755-4aaa-8b3d-a662cd059bc9"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("f1d740ce-d4aa-4275-940d-9ce6ada615e5"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("f862bbc9-55b5-4182-bda9-f3b48e087da1"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("20681464-4c2f-48e9-8298-1963d0ac0deb"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("86aa59e9-6e57-4a28-a688-dc2aa2c3b0e1"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("8c1dfd9f-da3e-4acf-be48-4dc6b1802c79"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("b1af4309-530b-4dbd-8d3b-5a6918951efa"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("bef8a1e0-6b79-4baa-87f9-b2d0ded980dc"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("c79cb02b-2097-4c64-a9eb-2d953622afaf"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0f270e07-4c82-4b53-bc0d-44e5c4a0f65e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1d761150-d68e-4a7d-b1eb-527a83369f41"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("224feaff-43f4-4366-975b-75c2d689a76f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2eb9569f-751b-4d04-b3cd-aa24d5584d90"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("383d9f77-1527-4a84-9c33-7f8d034c70e7"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("3a35d4f1-ea6a-47fb-bb07-9bc87cc47df5"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("40c74e46-0181-4ea4-b928-2ed3440ff77e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4648f33e-c68c-4a9a-894b-e00a81ef5244"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("488f3e25-4c93-4c73-8936-0e9fe2293ec6"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4cd7e92e-1fd6-4ff1-8751-41b42fd499b9"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("5711f618-c111-447c-a0ec-2e2c47de3f5c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("5b3707b6-6f4e-4b28-8625-7bbd3c7e35d2"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("5d1d6d82-9e97-486f-a4f0-9bb2eed129ad"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("740ff527-8fe4-42e2-a1c6-8760934ba25c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("78adbbff-4fd8-4fa6-be31-205035e14026"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("7aacb625-7458-4cac-9e19-a29285fbe3b2"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a5f89727-f36d-493b-b8a6-1107ea9bbaa8"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a91c046b-d7f9-4a3f-b79f-240a298762e9"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b5e332e8-5f46-4e25-8fb4-73a3d61d6782"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ba5bd906-a9ed-49eb-bd7a-f914e9f36226"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d1caa2a1-c28d-486d-95bf-0a4bf9ac1cbb"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d83738fa-2dff-430d-b6b2-4e4444f15ab2"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ddc34418-4987-45c2-a064-f377ccde17f0"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e5e9745c-aaa6-445e-abab-3a1e6fc37d72"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e91e0c01-65f6-4aef-b2e0-c0e3522d6290"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f0c9f6e4-2800-4bf0-9a13-a53462881f7f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f47d6cda-94f8-49f5-a3ea-c060e1a9a4b8"));

            migrationBuilder.DeleteData(
                table: "Readers",
                keyColumn: "Id",
                keyValue: new Guid("157f19f0-a66e-4161-b899-1ba14953519d"));

            migrationBuilder.DeleteData(
                table: "Readers",
                keyColumn: "Id",
                keyValue: new Guid("1957e470-5e20-46ed-9a4d-82ee39ec754e"));

            migrationBuilder.DeleteData(
                table: "Readers",
                keyColumn: "Id",
                keyValue: new Guid("6a2327b1-852d-441c-a3e6-95319def4f8f"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("096e7f43-42f7-4aec-aae5-8150ca544988"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("0d8b13ce-c312-4ab6-ade1-9f520572d3d1"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("0f0d814a-3f87-44f5-9cec-0b7ea94fb457"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("2e5348d6-5033-45ce-99ca-1246864751d5"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("4b2f9ce6-73b3-4140-ae76-dfce880a9ff6"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("5c836eab-abf2-4621-8d62-3094a83a685c"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("618e06c4-a6f5-42fd-85fa-6b1473fc7220"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("6508fcf2-37a6-40ee-a0eb-422586cb27b8"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("69adfa84-daf3-4a3d-8ad5-53daaa26ce96"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("6dae31df-8169-418a-aa5d-0877064a1df0"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("6dcdd6ed-f35c-4c82-8c28-79d2a9fece96"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("7d7b843f-53e7-411e-a59d-0e4e8a189187"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("8d717003-7ef7-4a4b-9e12-d5e7901873c3"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("9a61fa0e-cad5-4e65-b1e2-51f17e290a35"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("9b10a2bc-ae1e-4650-9731-b4227d89a109"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("9dd9f9cf-858a-4520-b138-ed6f59fb9ca2"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("aaaf05df-6fae-4cdd-baff-41227de9ff81"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("cb4a428b-6ebb-420e-aa6c-605a3e5de5a1"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("cde5099d-5d2f-40ee-b3d4-6f114e60d6a0"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("d23360a4-e749-4ead-beb2-cacabac0a81b"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("ef2c01fd-4e66-4f31-831d-2114abd85173"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("ef875e6c-d757-4174-b6d0-943e91a54ea6"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e729fae3-57e5-49eb-b51d-74be9d42544f", "AQAAAAIAAYagAAAAEHRoMPCRVXOJPa+QZZXfG7e4V9uxXCiP7m6949FC8EPYvExRD0P2/3wxIVu9BZ/TIQ==", "811c060f-3b61-4f57-b05c-3ddd89e4a152" });

            migrationBuilder.InsertData(
                table: "BookDefinitions",
                columns: new[] { "Id", "Author", "CoverImagePath", "Title" },
                values: new object[,]
                {
                    { new Guid("07913eae-9ea9-4414-8aa2-03095767cf21"), "J.K. Rowling", null, "Harry Potter i Kamień Filozoficzny" },
                    { new Guid("0c60955d-53e8-4563-8c47-2cc681c72a43"), "Johann Wolfgang von Goethe", null, "Cierpienia młodego Wertera" },
                    { new Guid("13d09eed-4525-494b-a5a7-1d1e8b570358"), "William Shakespeare", null, "Romeo i Julia" },
                    { new Guid("176bb127-2552-47a2-930f-f2ca8ea379f0"), "Andrzej Ziemiański", null, "Achaja. Tom I" },
                    { new Guid("2d0b7b52-4660-43c5-af33-5e545151d9e1"), "Jo Nesbø", null, "Człowiek nietoperz" },
                    { new Guid("4e23c486-b467-4454-95b0-cced2943d907"), "Stieg Larsson", null, "Mężczyźni, którzy nienawidzą kobiet" },
                    { new Guid("5390d6ee-4110-4afe-8973-282da308c7e2"), "J.K. Rowling", null, "Harry Potter i więzień Azkabanu" },
                    { new Guid("53ead14f-b23e-45cc-a972-1dc24e9a3424"), "Camilla Läckberg", null, "Księżniczka z lodu" },
                    { new Guid("612ab7d8-20e7-4200-8412-85b66b15fef0"), "Juliusz Słowacki", null, "Balladyna" },
                    { new Guid("618a6b7e-93d5-4996-b436-863c09d81da7"), "Camilla Läckberg", null, "Kaznodzieja" },
                    { new Guid("655d042a-d318-406a-8412-ab7250c5fcaa"), "J.K. Rowling", null, "Harry Potter i Czara Ognia" },
                    { new Guid("78fd8609-958a-404a-8e76-ad9620e6bb03"), "J.K. Rowling", null, "Harry Potter i Książę Półkrwi" },
                    { new Guid("7cb5de95-bcb7-4b29-a905-a4948f684804"), "Władysław Stanisław Reymont", null, "Chłopi" },
                    { new Guid("8f4c8b2c-c736-4bed-b288-3c1ae863b84f"), "George R.R. Martin", null, "Starcie królów (edycja ilustrowana)" },
                    { new Guid("9b15f13d-4b31-4735-aa18-3fcacfa550fe"), "J.K. Rowling", null, "Harry Potter i Komnata Tajemnic" },
                    { new Guid("a4c345ef-03fa-4b77-9387-8e85f8145409"), "Juliusz Słowacki", null, "Kordian" },
                    { new Guid("a8e541b1-398f-4f33-8290-bb6130bd81c8"), "Kornel Makuszyński", null, "Szatan z siódmej klasy" },
                    { new Guid("aa5d87f3-cdc3-4631-a983-4d62834e4fb3"), "George R.R. Martin", null, "Nawałnica mieczy: Stal i śnieg" },
                    { new Guid("acbe8d8c-0823-467a-9aff-7a5b8ca0176e"), "George R.R. Martin", null, "Gra o tron (edycja ilustrowana)" },
                    { new Guid("b6852f11-8ba9-4064-b4d7-10390ae65107"), "Camilla Läckberg", null, "Niemiecki bękart" },
                    { new Guid("bdad4fb2-d095-498c-8273-fa19ac17d799"), "Stanisław Wyspiański", null, "Wesele" },
                    { new Guid("c84c9e9c-c249-4225-bb57-24e639f691a4"), "Cassandra Clare", null, "Miasto upadłych aniołów" },
                    { new Guid("cdf00e59-8e6f-4baf-aacc-c71a1e2bb25a"), "Dan Brown", null, "Inferno" },
                    { new Guid("d21ca2bc-1dab-463e-8bb5-1512054a3ba7"), "J.K. Rowling, Jack Thorne", null, "Harry Potter i Przeklęte Dziecko" },
                    { new Guid("d5ed9c9a-a30f-43fd-b1ee-eb734c09c63f"), "Veronica Roth", null, "Niezgodna" },
                    { new Guid("dd259cc3-8168-4ad9-a084-96868d2b7aad"), "Camilla Läckberg", null, "Kamieniarz" },
                    { new Guid("e23a5b30-4b9f-489c-b1ca-d82ec805aace"), "J.K. Rowling", null, "Harry Potter i Zakon Feniksa" },
                    { new Guid("e98ff57a-788c-4bff-97f8-49dc00742736"), "Andrzej Sapkowski", null, "Narrenturm" },
                    { new Guid("f1559d9f-ca57-4ebe-994b-3b3313b11f54"), "Christopher Paolini", null, "Dziedzictwo" },
                    { new Guid("f1d275eb-c762-4af8-8148-4f3eaca07b3a"), "Camilla Läckberg", null, "Ofiara losu" }
                });

            migrationBuilder.InsertData(
                table: "Readers",
                columns: new[] { "Id", "City", "Code", "Name", "Street", "UserId" },
                values: new object[,]
                {
                    { new Guid("437b01ab-9a20-4e7b-ae77-2ab47be0d6c5"), "Poznań", "61-111", "Tomasz Rydz", "Garbary 1", null },
                    { new Guid("4a451efe-7c82-4401-a131-1aae044454f0"), "Poznań", "61-111", "Aleksandra Mechrzycka", "Solna 2", null },
                    { new Guid("785a2929-5604-4245-aa4d-2b7786aeadbd"), "Poznań", "61-311", "Jan Nowak", "Wieżowa 3", null }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "BookDefinitionId", "Comment", "Status" },
                values: new object[,]
                {
                    { new Guid("03f2d87a-6791-4741-b863-d2a1c6df02a0"), new Guid("5390d6ee-4110-4afe-8973-282da308c7e2"), null, 0 },
                    { new Guid("058ec9ab-a8e3-42da-9290-df58faa62a8c"), new Guid("176bb127-2552-47a2-930f-f2ca8ea379f0"), null, 1 },
                    { new Guid("0616b6d4-6925-44b0-996d-549d7a268426"), new Guid("78fd8609-958a-404a-8e76-ad9620e6bb03"), null, 1 },
                    { new Guid("0a44edaa-5697-44ab-b8ab-7c08b497acd4"), new Guid("655d042a-d318-406a-8412-ab7250c5fcaa"), null, 2 },
                    { new Guid("0a94853f-b266-451d-8b34-ba1fb38a5501"), new Guid("13d09eed-4525-494b-a5a7-1d1e8b570358"), null, 1 },
                    { new Guid("0d3352c1-64d0-484a-b2e3-380077d07901"), new Guid("d21ca2bc-1dab-463e-8bb5-1512054a3ba7"), null, 0 },
                    { new Guid("0d9fa12a-e997-4a19-aeb0-fe7606dda0fe"), new Guid("2d0b7b52-4660-43c5-af33-5e545151d9e1"), null, 0 },
                    { new Guid("0fd2b647-d423-425f-871b-2765fd4af17e"), new Guid("a8e541b1-398f-4f33-8290-bb6130bd81c8"), null, 1 },
                    { new Guid("1243510f-33ad-4cfe-977d-f97096cf7912"), new Guid("618a6b7e-93d5-4996-b436-863c09d81da7"), null, 1 },
                    { new Guid("1282ab03-1eee-452a-b0b1-ed33a3919b99"), new Guid("618a6b7e-93d5-4996-b436-863c09d81da7"), null, 2 },
                    { new Guid("1402fcb6-68c3-4e8e-9754-435fd067bf52"), new Guid("aa5d87f3-cdc3-4631-a983-4d62834e4fb3"), null, 0 },
                    { new Guid("17dd14f0-d15f-42b2-bd2d-8334302f4b45"), new Guid("655d042a-d318-406a-8412-ab7250c5fcaa"), null, 1 },
                    { new Guid("1b46a3d6-4174-4ab9-9918-0903f963e726"), new Guid("a8e541b1-398f-4f33-8290-bb6130bd81c8"), null, 0 },
                    { new Guid("1e613789-2cef-418d-b0c0-2a962d27ed58"), new Guid("8f4c8b2c-c736-4bed-b288-3c1ae863b84f"), null, 0 },
                    { new Guid("1f2f7987-198b-40cf-a0a5-3b20b4518a66"), new Guid("f1d275eb-c762-4af8-8148-4f3eaca07b3a"), null, 2 },
                    { new Guid("20a8d076-6834-448f-9e6c-087031ba6d65"), new Guid("13d09eed-4525-494b-a5a7-1d1e8b570358"), null, 0 },
                    { new Guid("22aabf87-66a1-4e93-b308-4b5b460861cc"), new Guid("aa5d87f3-cdc3-4631-a983-4d62834e4fb3"), null, 0 },
                    { new Guid("24c14d23-1836-43b7-b3b3-df3bb562af91"), new Guid("0c60955d-53e8-4563-8c47-2cc681c72a43"), null, 0 },
                    { new Guid("26d05eb0-ece9-4b0e-a23f-4af0ef75c0e5"), new Guid("cdf00e59-8e6f-4baf-aacc-c71a1e2bb25a"), null, 0 },
                    { new Guid("29fa7e90-1a3b-4344-864a-87e24963b7fc"), new Guid("d21ca2bc-1dab-463e-8bb5-1512054a3ba7"), null, 2 },
                    { new Guid("2ba1a9b1-bdf5-4483-b90f-9b7dafdd4134"), new Guid("4e23c486-b467-4454-95b0-cced2943d907"), null, 0 },
                    { new Guid("2e2a1e35-621a-4181-b898-6a08e9a4e9ad"), new Guid("d21ca2bc-1dab-463e-8bb5-1512054a3ba7"), null, 1 },
                    { new Guid("3254379f-42df-436b-9361-8dc799b25c22"), new Guid("f1559d9f-ca57-4ebe-994b-3b3313b11f54"), null, 0 },
                    { new Guid("35f4f434-363b-48ef-9bbe-da2104771b4e"), new Guid("4e23c486-b467-4454-95b0-cced2943d907"), null, 1 },
                    { new Guid("36efaff9-67e1-4a8e-b435-f524a61e21a8"), new Guid("07913eae-9ea9-4414-8aa2-03095767cf21"), null, 1 },
                    { new Guid("38be8756-f66e-4174-b1f4-2bbd26a208bd"), new Guid("a4c345ef-03fa-4b77-9387-8e85f8145409"), null, 2 },
                    { new Guid("3cca77c9-905e-4d03-9cd9-c62116b192d6"), new Guid("e23a5b30-4b9f-489c-b1ca-d82ec805aace"), null, 0 },
                    { new Guid("3eb520c7-d7da-4555-80bf-ab1b0b4bc4d3"), new Guid("d21ca2bc-1dab-463e-8bb5-1512054a3ba7"), null, 0 },
                    { new Guid("40fc90cb-7ae0-4d7d-a414-50ba37bb8c85"), new Guid("8f4c8b2c-c736-4bed-b288-3c1ae863b84f"), null, 2 },
                    { new Guid("42e6f167-1f31-43f4-8c42-25ee594b8827"), new Guid("53ead14f-b23e-45cc-a972-1dc24e9a3424"), null, 2 },
                    { new Guid("46f985c2-c186-492d-ae97-1932a614ba41"), new Guid("c84c9e9c-c249-4225-bb57-24e639f691a4"), null, 0 },
                    { new Guid("48390173-b528-4016-a275-24138d338c56"), new Guid("176bb127-2552-47a2-930f-f2ca8ea379f0"), null, 0 },
                    { new Guid("490d4c28-d160-4985-bbf3-c3dd816e5687"), new Guid("f1559d9f-ca57-4ebe-994b-3b3313b11f54"), null, 1 },
                    { new Guid("52652373-ba83-447d-b11a-9a8abb4e718d"), new Guid("a4c345ef-03fa-4b77-9387-8e85f8145409"), null, 2 },
                    { new Guid("537c3ae5-9ddf-4298-aef6-75d6e185a71f"), new Guid("2d0b7b52-4660-43c5-af33-5e545151d9e1"), null, 0 },
                    { new Guid("5475f152-71b1-4c78-a6cb-fb87c9f0a97d"), new Guid("e98ff57a-788c-4bff-97f8-49dc00742736"), null, 0 },
                    { new Guid("54f7cbec-d698-4135-812b-ebb817d9668b"), new Guid("aa5d87f3-cdc3-4631-a983-4d62834e4fb3"), null, 0 },
                    { new Guid("571a6bfd-df71-41c8-8ae2-1ab45996587f"), new Guid("c84c9e9c-c249-4225-bb57-24e639f691a4"), null, 2 },
                    { new Guid("5d3e80e1-a3bc-4ccf-82e8-b0d6b8d0ee9e"), new Guid("9b15f13d-4b31-4735-aa18-3fcacfa550fe"), null, 0 },
                    { new Guid("5f983603-10c8-4afe-bd87-0485833bbe84"), new Guid("c84c9e9c-c249-4225-bb57-24e639f691a4"), null, 0 },
                    { new Guid("63ab595b-668b-4c1f-8f90-40d1f3386e34"), new Guid("bdad4fb2-d095-498c-8273-fa19ac17d799"), null, 0 },
                    { new Guid("64f6c1cf-969c-404d-9156-5cad2e6c8840"), new Guid("dd259cc3-8168-4ad9-a084-96868d2b7aad"), null, 0 },
                    { new Guid("65d11cff-6a79-44fc-ba05-672f0b767653"), new Guid("618a6b7e-93d5-4996-b436-863c09d81da7"), null, 0 },
                    { new Guid("68d14cd9-7ecd-417f-bf6b-59548d028bbc"), new Guid("d5ed9c9a-a30f-43fd-b1ee-eb734c09c63f"), null, 2 },
                    { new Guid("6c7ab22c-6147-40fe-ac16-60d3f1b724e5"), new Guid("9b15f13d-4b31-4735-aa18-3fcacfa550fe"), null, 0 },
                    { new Guid("6cb61164-2384-45df-a8ff-5850ed9212ca"), new Guid("e98ff57a-788c-4bff-97f8-49dc00742736"), null, 0 },
                    { new Guid("6ddade96-4f35-4b8d-996f-914f6c5c45e8"), new Guid("5390d6ee-4110-4afe-8973-282da308c7e2"), null, 0 },
                    { new Guid("718b8bc8-7a8a-4951-9c97-1546cab4fdc5"), new Guid("612ab7d8-20e7-4200-8412-85b66b15fef0"), null, 2 },
                    { new Guid("731df53e-f4b0-47ac-b077-b3ccd05dbe2a"), new Guid("07913eae-9ea9-4414-8aa2-03095767cf21"), null, 2 },
                    { new Guid("77b19b20-e03d-4489-a278-035c19eb64fe"), new Guid("f1d275eb-c762-4af8-8148-4f3eaca07b3a"), null, 0 },
                    { new Guid("7a9a18d2-00b3-4b90-894b-da37a09d5e70"), new Guid("a8e541b1-398f-4f33-8290-bb6130bd81c8"), null, 0 },
                    { new Guid("7dc1c55f-52b9-44ee-9afb-566661cb6b08"), new Guid("d5ed9c9a-a30f-43fd-b1ee-eb734c09c63f"), null, 2 },
                    { new Guid("7df14d9f-7a50-4c6c-b673-4f37c02b4ea4"), new Guid("618a6b7e-93d5-4996-b436-863c09d81da7"), null, 1 },
                    { new Guid("7ebf04b7-695f-49ce-81c6-9b295766f1d6"), new Guid("f1d275eb-c762-4af8-8148-4f3eaca07b3a"), null, 0 },
                    { new Guid("829269af-7a8c-4b48-bef5-8fcd14b16e39"), new Guid("618a6b7e-93d5-4996-b436-863c09d81da7"), null, 1 },
                    { new Guid("85504c8d-2d90-4a4f-8d28-2c7ab48f5924"), new Guid("7cb5de95-bcb7-4b29-a905-a4948f684804"), null, 0 },
                    { new Guid("8ab21a42-fa2f-480e-bd0a-7d304c66db2f"), new Guid("acbe8d8c-0823-467a-9aff-7a5b8ca0176e"), null, 0 },
                    { new Guid("92146115-0a43-4aba-9f03-a4d16dff657c"), new Guid("07913eae-9ea9-4414-8aa2-03095767cf21"), null, 2 },
                    { new Guid("92bfb811-965a-42a7-b55d-6812679fd610"), new Guid("d21ca2bc-1dab-463e-8bb5-1512054a3ba7"), null, 0 },
                    { new Guid("947b882f-f1de-4f05-bafd-e76ade1f9115"), new Guid("9b15f13d-4b31-4735-aa18-3fcacfa550fe"), null, 2 },
                    { new Guid("9a202ac2-6fb9-4dfa-8fd9-3a510570b73b"), new Guid("7cb5de95-bcb7-4b29-a905-a4948f684804"), null, 1 },
                    { new Guid("9b374c38-1e4b-424b-85b3-9dd528279ad2"), new Guid("612ab7d8-20e7-4200-8412-85b66b15fef0"), null, 0 },
                    { new Guid("9c606f65-4b1f-4c05-a099-a251b81d9f2b"), new Guid("5390d6ee-4110-4afe-8973-282da308c7e2"), null, 1 },
                    { new Guid("9e41c791-55b5-4b9a-8815-1dba31e2bcf0"), new Guid("b6852f11-8ba9-4064-b4d7-10390ae65107"), null, 2 },
                    { new Guid("9e6a7ac2-ed88-4935-a52e-bc4e2d8f1891"), new Guid("618a6b7e-93d5-4996-b436-863c09d81da7"), null, 1 },
                    { new Guid("a4498221-c3e0-4141-a23c-254f49a89ebb"), new Guid("07913eae-9ea9-4414-8aa2-03095767cf21"), null, 1 },
                    { new Guid("aa9ea010-251c-432a-a419-758ea1449d08"), new Guid("618a6b7e-93d5-4996-b436-863c09d81da7"), null, 2 },
                    { new Guid("adcba8af-d725-4ae9-8d03-a1231aa1d260"), new Guid("aa5d87f3-cdc3-4631-a983-4d62834e4fb3"), null, 1 },
                    { new Guid("aea865ed-d0f5-435e-adaf-929ac8fbbcf1"), new Guid("53ead14f-b23e-45cc-a972-1dc24e9a3424"), null, 0 },
                    { new Guid("b21f7b8c-56cc-4d35-a56c-a5ffa91be616"), new Guid("aa5d87f3-cdc3-4631-a983-4d62834e4fb3"), null, 1 },
                    { new Guid("b379ec81-a3fe-4632-bb79-c1191da2cd81"), new Guid("f1d275eb-c762-4af8-8148-4f3eaca07b3a"), null, 0 },
                    { new Guid("b4339544-5e4d-4bd8-9bab-bfcbcef352e2"), new Guid("f1d275eb-c762-4af8-8148-4f3eaca07b3a"), null, 0 },
                    { new Guid("baf0709f-bf7b-47ac-b3fb-3861138b08b1"), new Guid("78fd8609-958a-404a-8e76-ad9620e6bb03"), null, 2 },
                    { new Guid("bcb764da-31ad-42b6-a22b-a1c5c2a1b26d"), new Guid("aa5d87f3-cdc3-4631-a983-4d62834e4fb3"), null, 0 },
                    { new Guid("be89ac0c-e9dc-4f0c-a3db-1ea562385fd4"), new Guid("618a6b7e-93d5-4996-b436-863c09d81da7"), null, 1 },
                    { new Guid("c582778e-8c6f-4c52-84f7-7d01eb2e3a6f"), new Guid("618a6b7e-93d5-4996-b436-863c09d81da7"), null, 2 },
                    { new Guid("c62cf2d8-1175-411f-92a0-fe6ac4bcb771"), new Guid("2d0b7b52-4660-43c5-af33-5e545151d9e1"), null, 2 },
                    { new Guid("c708f6d4-ab95-4c05-a0cf-335d140fb7fe"), new Guid("a8e541b1-398f-4f33-8290-bb6130bd81c8"), null, 1 },
                    { new Guid("ca78df1e-8117-4306-8b5d-445034aac1a5"), new Guid("e98ff57a-788c-4bff-97f8-49dc00742736"), null, 2 },
                    { new Guid("cc0e4979-c57c-4995-a8c9-8f7e8c35fbb3"), new Guid("5390d6ee-4110-4afe-8973-282da308c7e2"), null, 0 },
                    { new Guid("d1189a53-c3b8-473b-aef1-8b5ecd6a2bed"), new Guid("13d09eed-4525-494b-a5a7-1d1e8b570358"), null, 1 },
                    { new Guid("d343aa12-27bc-4e12-ba0d-f92ea5016348"), new Guid("aa5d87f3-cdc3-4631-a983-4d62834e4fb3"), null, 0 },
                    { new Guid("d48daad4-7925-4788-83fa-e688c1c2d0a4"), new Guid("0c60955d-53e8-4563-8c47-2cc681c72a43"), null, 1 },
                    { new Guid("dac626bb-f546-485d-ada0-929a65482542"), new Guid("f1d275eb-c762-4af8-8148-4f3eaca07b3a"), null, 0 },
                    { new Guid("dcf6a437-a2e9-4f07-8b94-be6f87760c4a"), new Guid("9b15f13d-4b31-4735-aa18-3fcacfa550fe"), null, 1 },
                    { new Guid("e4501d98-cfc9-44e1-a976-0b4087076a59"), new Guid("b6852f11-8ba9-4064-b4d7-10390ae65107"), null, 2 },
                    { new Guid("e5618def-55b6-492a-8799-a308504a858b"), new Guid("aa5d87f3-cdc3-4631-a983-4d62834e4fb3"), null, 1 },
                    { new Guid("e77acec1-f669-4c72-87fd-9d103304c1e6"), new Guid("5390d6ee-4110-4afe-8973-282da308c7e2"), null, 1 },
                    { new Guid("e84c3c0d-424f-4cac-8787-cfa769a03f4f"), new Guid("d21ca2bc-1dab-463e-8bb5-1512054a3ba7"), null, 0 },
                    { new Guid("ee8daf79-6bd1-46f1-ba70-35b583abfdc6"), new Guid("618a6b7e-93d5-4996-b436-863c09d81da7"), null, 0 },
                    { new Guid("ef9ab9a5-208f-4792-bfb2-f8f6128727ac"), new Guid("f1559d9f-ca57-4ebe-994b-3b3313b11f54"), null, 2 },
                    { new Guid("f4234669-0cf6-497a-ba87-78d3e1d2431b"), new Guid("8f4c8b2c-c736-4bed-b288-3c1ae863b84f"), null, 2 },
                    { new Guid("f6300740-1025-4dec-898f-cce0e6f68103"), new Guid("acbe8d8c-0823-467a-9aff-7a5b8ca0176e"), null, 2 },
                    { new Guid("f6fdf555-7445-4a25-8313-d020fc757144"), new Guid("4e23c486-b467-4454-95b0-cced2943d907"), null, 1 },
                    { new Guid("f73a96b3-270e-4e47-a86e-58776b7b6c89"), new Guid("176bb127-2552-47a2-930f-f2ca8ea379f0"), null, 2 },
                    { new Guid("f815c08a-8040-44be-9a6e-a24df7754312"), new Guid("78fd8609-958a-404a-8e76-ad9620e6bb03"), null, 1 },
                    { new Guid("f8fceddd-1d9e-48e1-9b40-740b0ab03e83"), new Guid("cdf00e59-8e6f-4baf-aacc-c71a1e2bb25a"), null, 0 },
                    { new Guid("f9c49789-ccc4-41ef-96ca-94f139a326d4"), new Guid("13d09eed-4525-494b-a5a7-1d1e8b570358"), null, 2 },
                    { new Guid("fd85325e-b232-4b3c-a7f0-7f9cdb2e9ac1"), new Guid("d5ed9c9a-a30f-43fd-b1ee-eb734c09c63f"), null, 2 },
                    { new Guid("ffe10b9e-a727-4cb4-b2dc-07de9860f364"), new Guid("2d0b7b52-4660-43c5-af33-5e545151d9e1"), null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Borrowings",
                columns: new[] { "Id", "BookId", "BorrowDate", "ReaderId", "ReturnDate" },
                values: new object[,]
                {
                    { new Guid("010619e4-3e12-4797-a996-410e92784d40"), new Guid("17dd14f0-d15f-42b2-bd2d-8334302f4b45"), new DateTime(2025, 5, 22, 0, 0, 0, 0, DateTimeKind.Local), new Guid("4a451efe-7c82-4401-a131-1aae044454f0"), new DateTime(2025, 7, 21, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("0ecb38d8-15dc-4354-8455-7cd1c6c13578"), new Guid("36efaff9-67e1-4a8e-b435-f524a61e21a8"), new DateTime(2025, 5, 28, 0, 0, 0, 0, DateTimeKind.Local), new Guid("785a2929-5604-4245-aa4d-2b7786aeadbd"), new DateTime(2025, 7, 27, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("139f2b1f-c932-4bf7-a639-5ca19722039f"), new Guid("2e2a1e35-621a-4181-b898-6a08e9a4e9ad"), new DateTime(2025, 5, 23, 0, 0, 0, 0, DateTimeKind.Local), new Guid("4a451efe-7c82-4401-a131-1aae044454f0"), new DateTime(2025, 7, 22, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("1a19aac1-5f81-4906-9f8b-344b4e7a3908"), new Guid("7df14d9f-7a50-4c6c-b673-4f37c02b4ea4"), new DateTime(2025, 5, 30, 0, 0, 0, 0, DateTimeKind.Local), new Guid("437b01ab-9a20-4e7b-ae77-2ab47be0d6c5"), new DateTime(2025, 7, 29, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("21059172-d610-4f1d-a450-4ab76c977481"), new Guid("d1189a53-c3b8-473b-aef1-8b5ecd6a2bed"), new DateTime(2025, 5, 28, 0, 0, 0, 0, DateTimeKind.Local), new Guid("437b01ab-9a20-4e7b-ae77-2ab47be0d6c5"), new DateTime(2025, 7, 27, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("223a9173-a281-48d0-a291-1dc6d955bcec"), new Guid("0a94853f-b266-451d-8b34-ba1fb38a5501"), new DateTime(2025, 5, 24, 0, 0, 0, 0, DateTimeKind.Local), new Guid("785a2929-5604-4245-aa4d-2b7786aeadbd"), new DateTime(2025, 7, 23, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("2245ba3a-d87c-4695-a171-f779d405a327"), new Guid("35f4f434-363b-48ef-9bbe-da2104771b4e"), new DateTime(2025, 5, 18, 0, 0, 0, 0, DateTimeKind.Local), new Guid("5d31a024-4e84-4f5e-b86b-04b10d79559e"), new DateTime(2025, 7, 17, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("25b76f3d-3a62-4ac1-9e42-aae827c43914"), new Guid("e5618def-55b6-492a-8799-a308504a858b"), new DateTime(2025, 5, 29, 0, 0, 0, 0, DateTimeKind.Local), new Guid("785a2929-5604-4245-aa4d-2b7786aeadbd"), new DateTime(2025, 7, 28, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("2a7963ff-ba3c-4779-b297-5f9a3bd8ab5c"), new Guid("a4498221-c3e0-4141-a23c-254f49a89ebb"), new DateTime(2025, 5, 29, 0, 0, 0, 0, DateTimeKind.Local), new Guid("785a2929-5604-4245-aa4d-2b7786aeadbd"), new DateTime(2025, 7, 28, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("2f10571c-b2f3-4ba0-bcc1-22168899dc94"), new Guid("9e6a7ac2-ed88-4935-a52e-bc4e2d8f1891"), new DateTime(2025, 5, 18, 0, 0, 0, 0, DateTimeKind.Local), new Guid("785a2929-5604-4245-aa4d-2b7786aeadbd"), new DateTime(2025, 7, 17, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("37b73b12-3207-4b65-9482-ca6f550a6a98"), new Guid("f6fdf555-7445-4a25-8313-d020fc757144"), new DateTime(2025, 5, 18, 0, 0, 0, 0, DateTimeKind.Local), new Guid("437b01ab-9a20-4e7b-ae77-2ab47be0d6c5"), new DateTime(2025, 7, 17, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("42584adc-d258-4b32-b1e8-fe244c761537"), new Guid("0616b6d4-6925-44b0-996d-549d7a268426"), new DateTime(2025, 5, 30, 0, 0, 0, 0, DateTimeKind.Local), new Guid("785a2929-5604-4245-aa4d-2b7786aeadbd"), new DateTime(2025, 7, 29, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("45b6e149-169e-4035-892c-14489b598aa3"), new Guid("0fd2b647-d423-425f-871b-2765fd4af17e"), new DateTime(2025, 5, 20, 0, 0, 0, 0, DateTimeKind.Local), new Guid("437b01ab-9a20-4e7b-ae77-2ab47be0d6c5"), new DateTime(2025, 7, 19, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("46b68ef5-9b05-459f-9212-d946095eb983"), new Guid("adcba8af-d725-4ae9-8d03-a1231aa1d260"), new DateTime(2025, 5, 20, 0, 0, 0, 0, DateTimeKind.Local), new Guid("4a451efe-7c82-4401-a131-1aae044454f0"), new DateTime(2025, 7, 19, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("50e0d53e-56d3-47a3-835b-d5e848568d6b"), new Guid("b21f7b8c-56cc-4d35-a56c-a5ffa91be616"), new DateTime(2025, 5, 17, 0, 0, 0, 0, DateTimeKind.Local), new Guid("4a451efe-7c82-4401-a131-1aae044454f0"), new DateTime(2025, 7, 16, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("516a3e4d-8a52-48e9-b452-7d84a101afeb"), new Guid("9a202ac2-6fb9-4dfa-8fd9-3a510570b73b"), new DateTime(2025, 5, 25, 0, 0, 0, 0, DateTimeKind.Local), new Guid("5d31a024-4e84-4f5e-b86b-04b10d79559e"), new DateTime(2025, 7, 24, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("5ce844bf-c210-4ae5-8173-44ddaa161996"), new Guid("dcf6a437-a2e9-4f07-8b94-be6f87760c4a"), new DateTime(2025, 5, 17, 0, 0, 0, 0, DateTimeKind.Local), new Guid("4a451efe-7c82-4401-a131-1aae044454f0"), new DateTime(2025, 7, 16, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("5d59f0b4-3a38-4f2b-93d2-a6b722de265b"), new Guid("9c606f65-4b1f-4c05-a099-a251b81d9f2b"), new DateTime(2025, 5, 30, 0, 0, 0, 0, DateTimeKind.Local), new Guid("785a2929-5604-4245-aa4d-2b7786aeadbd"), new DateTime(2025, 7, 29, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("649cc5c3-626e-41e8-a21a-beb5452cf0d0"), new Guid("c708f6d4-ab95-4c05-a0cf-335d140fb7fe"), new DateTime(2025, 5, 26, 0, 0, 0, 0, DateTimeKind.Local), new Guid("785a2929-5604-4245-aa4d-2b7786aeadbd"), new DateTime(2025, 7, 25, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("8346f9cb-946a-4132-bf39-d700a55218cf"), new Guid("829269af-7a8c-4b48-bef5-8fcd14b16e39"), new DateTime(2025, 5, 22, 0, 0, 0, 0, DateTimeKind.Local), new Guid("437b01ab-9a20-4e7b-ae77-2ab47be0d6c5"), new DateTime(2025, 7, 21, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("8a5e9b15-c85d-4dd0-8102-cad9a8f52bd5"), new Guid("f815c08a-8040-44be-9a6e-a24df7754312"), new DateTime(2025, 5, 17, 0, 0, 0, 0, DateTimeKind.Local), new Guid("5d31a024-4e84-4f5e-b86b-04b10d79559e"), new DateTime(2025, 7, 16, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("9eb02121-8815-4792-a8b4-727d10bc4843"), new Guid("d48daad4-7925-4788-83fa-e688c1c2d0a4"), new DateTime(2025, 5, 25, 0, 0, 0, 0, DateTimeKind.Local), new Guid("437b01ab-9a20-4e7b-ae77-2ab47be0d6c5"), new DateTime(2025, 7, 24, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("a044d147-3e3b-45eb-af9f-0a5e16e16e8e"), new Guid("be89ac0c-e9dc-4f0c-a3db-1ea562385fd4"), new DateTime(2025, 5, 27, 0, 0, 0, 0, DateTimeKind.Local), new Guid("785a2929-5604-4245-aa4d-2b7786aeadbd"), new DateTime(2025, 7, 26, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("b29a99d7-b642-4d53-b8f5-94fb646a3194"), new Guid("058ec9ab-a8e3-42da-9290-df58faa62a8c"), new DateTime(2025, 5, 29, 0, 0, 0, 0, DateTimeKind.Local), new Guid("4a451efe-7c82-4401-a131-1aae044454f0"), new DateTime(2025, 7, 28, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("b95f2458-58e1-445b-9741-9ef8ef618466"), new Guid("1243510f-33ad-4cfe-977d-f97096cf7912"), new DateTime(2025, 5, 17, 0, 0, 0, 0, DateTimeKind.Local), new Guid("5d31a024-4e84-4f5e-b86b-04b10d79559e"), new DateTime(2025, 7, 16, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("e7398e81-fe00-41bc-bf13-5ee50a44424d"), new Guid("490d4c28-d160-4985-bbf3-c3dd816e5687"), new DateTime(2025, 5, 18, 0, 0, 0, 0, DateTimeKind.Local), new Guid("5d31a024-4e84-4f5e-b86b-04b10d79559e"), new DateTime(2025, 7, 17, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("eb5099cc-b154-48ac-b912-95dbc5cacc3e"), new Guid("e77acec1-f669-4c72-87fd-9d103304c1e6"), new DateTime(2025, 5, 22, 0, 0, 0, 0, DateTimeKind.Local), new Guid("4a451efe-7c82-4401-a131-1aae044454f0"), new DateTime(2025, 7, 21, 0, 0, 0, 0, DateTimeKind.Local) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("03f2d87a-6791-4741-b863-d2a1c6df02a0"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0a44edaa-5697-44ab-b8ab-7c08b497acd4"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0d3352c1-64d0-484a-b2e3-380077d07901"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0d9fa12a-e997-4a19-aeb0-fe7606dda0fe"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1282ab03-1eee-452a-b0b1-ed33a3919b99"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1402fcb6-68c3-4e8e-9754-435fd067bf52"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1b46a3d6-4174-4ab9-9918-0903f963e726"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1e613789-2cef-418d-b0c0-2a962d27ed58"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1f2f7987-198b-40cf-a0a5-3b20b4518a66"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("20a8d076-6834-448f-9e6c-087031ba6d65"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("22aabf87-66a1-4e93-b308-4b5b460861cc"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("24c14d23-1836-43b7-b3b3-df3bb562af91"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("26d05eb0-ece9-4b0e-a23f-4af0ef75c0e5"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("29fa7e90-1a3b-4344-864a-87e24963b7fc"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2ba1a9b1-bdf5-4483-b90f-9b7dafdd4134"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("3254379f-42df-436b-9361-8dc799b25c22"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("38be8756-f66e-4174-b1f4-2bbd26a208bd"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("3cca77c9-905e-4d03-9cd9-c62116b192d6"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("3eb520c7-d7da-4555-80bf-ab1b0b4bc4d3"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("40fc90cb-7ae0-4d7d-a414-50ba37bb8c85"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("42e6f167-1f31-43f4-8c42-25ee594b8827"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("46f985c2-c186-492d-ae97-1932a614ba41"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("48390173-b528-4016-a275-24138d338c56"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("52652373-ba83-447d-b11a-9a8abb4e718d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("537c3ae5-9ddf-4298-aef6-75d6e185a71f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("5475f152-71b1-4c78-a6cb-fb87c9f0a97d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("54f7cbec-d698-4135-812b-ebb817d9668b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("571a6bfd-df71-41c8-8ae2-1ab45996587f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("5d3e80e1-a3bc-4ccf-82e8-b0d6b8d0ee9e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("5f983603-10c8-4afe-bd87-0485833bbe84"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("63ab595b-668b-4c1f-8f90-40d1f3386e34"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("64f6c1cf-969c-404d-9156-5cad2e6c8840"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("65d11cff-6a79-44fc-ba05-672f0b767653"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("68d14cd9-7ecd-417f-bf6b-59548d028bbc"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("6c7ab22c-6147-40fe-ac16-60d3f1b724e5"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("6cb61164-2384-45df-a8ff-5850ed9212ca"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("6ddade96-4f35-4b8d-996f-914f6c5c45e8"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("718b8bc8-7a8a-4951-9c97-1546cab4fdc5"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("731df53e-f4b0-47ac-b077-b3ccd05dbe2a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("77b19b20-e03d-4489-a278-035c19eb64fe"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("7a9a18d2-00b3-4b90-894b-da37a09d5e70"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("7dc1c55f-52b9-44ee-9afb-566661cb6b08"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("7ebf04b7-695f-49ce-81c6-9b295766f1d6"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("85504c8d-2d90-4a4f-8d28-2c7ab48f5924"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8ab21a42-fa2f-480e-bd0a-7d304c66db2f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("92146115-0a43-4aba-9f03-a4d16dff657c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("92bfb811-965a-42a7-b55d-6812679fd610"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("947b882f-f1de-4f05-bafd-e76ade1f9115"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9b374c38-1e4b-424b-85b3-9dd528279ad2"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9e41c791-55b5-4b9a-8815-1dba31e2bcf0"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("aa9ea010-251c-432a-a419-758ea1449d08"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("aea865ed-d0f5-435e-adaf-929ac8fbbcf1"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b379ec81-a3fe-4632-bb79-c1191da2cd81"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b4339544-5e4d-4bd8-9bab-bfcbcef352e2"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("baf0709f-bf7b-47ac-b3fb-3861138b08b1"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("bcb764da-31ad-42b6-a22b-a1c5c2a1b26d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c582778e-8c6f-4c52-84f7-7d01eb2e3a6f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c62cf2d8-1175-411f-92a0-fe6ac4bcb771"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ca78df1e-8117-4306-8b5d-445034aac1a5"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("cc0e4979-c57c-4995-a8c9-8f7e8c35fbb3"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d343aa12-27bc-4e12-ba0d-f92ea5016348"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("dac626bb-f546-485d-ada0-929a65482542"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e4501d98-cfc9-44e1-a976-0b4087076a59"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e84c3c0d-424f-4cac-8787-cfa769a03f4f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ee8daf79-6bd1-46f1-ba70-35b583abfdc6"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ef9ab9a5-208f-4792-bfb2-f8f6128727ac"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f4234669-0cf6-497a-ba87-78d3e1d2431b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f6300740-1025-4dec-898f-cce0e6f68103"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f73a96b3-270e-4e47-a86e-58776b7b6c89"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f8fceddd-1d9e-48e1-9b40-740b0ab03e83"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f9c49789-ccc4-41ef-96ca-94f139a326d4"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("fd85325e-b232-4b3c-a7f0-7f9cdb2e9ac1"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ffe10b9e-a727-4cb4-b2dc-07de9860f364"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("010619e4-3e12-4797-a996-410e92784d40"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("0ecb38d8-15dc-4354-8455-7cd1c6c13578"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("139f2b1f-c932-4bf7-a639-5ca19722039f"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("1a19aac1-5f81-4906-9f8b-344b4e7a3908"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("21059172-d610-4f1d-a450-4ab76c977481"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("223a9173-a281-48d0-a291-1dc6d955bcec"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("2245ba3a-d87c-4695-a171-f779d405a327"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("25b76f3d-3a62-4ac1-9e42-aae827c43914"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("2a7963ff-ba3c-4779-b297-5f9a3bd8ab5c"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("2f10571c-b2f3-4ba0-bcc1-22168899dc94"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("37b73b12-3207-4b65-9482-ca6f550a6a98"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("42584adc-d258-4b32-b1e8-fe244c761537"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("45b6e149-169e-4035-892c-14489b598aa3"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("46b68ef5-9b05-459f-9212-d946095eb983"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("50e0d53e-56d3-47a3-835b-d5e848568d6b"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("516a3e4d-8a52-48e9-b452-7d84a101afeb"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("5ce844bf-c210-4ae5-8173-44ddaa161996"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("5d59f0b4-3a38-4f2b-93d2-a6b722de265b"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("649cc5c3-626e-41e8-a21a-beb5452cf0d0"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("8346f9cb-946a-4132-bf39-d700a55218cf"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("8a5e9b15-c85d-4dd0-8102-cad9a8f52bd5"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("9eb02121-8815-4792-a8b4-727d10bc4843"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("a044d147-3e3b-45eb-af9f-0a5e16e16e8e"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("b29a99d7-b642-4d53-b8f5-94fb646a3194"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("b95f2458-58e1-445b-9741-9ef8ef618466"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("e7398e81-fe00-41bc-bf13-5ee50a44424d"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("eb5099cc-b154-48ac-b912-95dbc5cacc3e"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("2d0b7b52-4660-43c5-af33-5e545151d9e1"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("53ead14f-b23e-45cc-a972-1dc24e9a3424"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("612ab7d8-20e7-4200-8412-85b66b15fef0"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("8f4c8b2c-c736-4bed-b288-3c1ae863b84f"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("a4c345ef-03fa-4b77-9387-8e85f8145409"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("acbe8d8c-0823-467a-9aff-7a5b8ca0176e"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("b6852f11-8ba9-4064-b4d7-10390ae65107"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("bdad4fb2-d095-498c-8273-fa19ac17d799"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("c84c9e9c-c249-4225-bb57-24e639f691a4"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("cdf00e59-8e6f-4baf-aacc-c71a1e2bb25a"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("d5ed9c9a-a30f-43fd-b1ee-eb734c09c63f"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("dd259cc3-8168-4ad9-a084-96868d2b7aad"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("e23a5b30-4b9f-489c-b1ca-d82ec805aace"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("e98ff57a-788c-4bff-97f8-49dc00742736"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("f1d275eb-c762-4af8-8148-4f3eaca07b3a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("058ec9ab-a8e3-42da-9290-df58faa62a8c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0616b6d4-6925-44b0-996d-549d7a268426"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0a94853f-b266-451d-8b34-ba1fb38a5501"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0fd2b647-d423-425f-871b-2765fd4af17e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1243510f-33ad-4cfe-977d-f97096cf7912"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("17dd14f0-d15f-42b2-bd2d-8334302f4b45"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2e2a1e35-621a-4181-b898-6a08e9a4e9ad"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("35f4f434-363b-48ef-9bbe-da2104771b4e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("36efaff9-67e1-4a8e-b435-f524a61e21a8"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("490d4c28-d160-4985-bbf3-c3dd816e5687"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("7df14d9f-7a50-4c6c-b673-4f37c02b4ea4"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("829269af-7a8c-4b48-bef5-8fcd14b16e39"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9a202ac2-6fb9-4dfa-8fd9-3a510570b73b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9c606f65-4b1f-4c05-a099-a251b81d9f2b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9e6a7ac2-ed88-4935-a52e-bc4e2d8f1891"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a4498221-c3e0-4141-a23c-254f49a89ebb"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("adcba8af-d725-4ae9-8d03-a1231aa1d260"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b21f7b8c-56cc-4d35-a56c-a5ffa91be616"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("be89ac0c-e9dc-4f0c-a3db-1ea562385fd4"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c708f6d4-ab95-4c05-a0cf-335d140fb7fe"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d1189a53-c3b8-473b-aef1-8b5ecd6a2bed"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d48daad4-7925-4788-83fa-e688c1c2d0a4"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("dcf6a437-a2e9-4f07-8b94-be6f87760c4a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e5618def-55b6-492a-8799-a308504a858b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e77acec1-f669-4c72-87fd-9d103304c1e6"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f6fdf555-7445-4a25-8313-d020fc757144"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f815c08a-8040-44be-9a6e-a24df7754312"));

            migrationBuilder.DeleteData(
                table: "Readers",
                keyColumn: "Id",
                keyValue: new Guid("437b01ab-9a20-4e7b-ae77-2ab47be0d6c5"));

            migrationBuilder.DeleteData(
                table: "Readers",
                keyColumn: "Id",
                keyValue: new Guid("4a451efe-7c82-4401-a131-1aae044454f0"));

            migrationBuilder.DeleteData(
                table: "Readers",
                keyColumn: "Id",
                keyValue: new Guid("785a2929-5604-4245-aa4d-2b7786aeadbd"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("07913eae-9ea9-4414-8aa2-03095767cf21"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("0c60955d-53e8-4563-8c47-2cc681c72a43"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("13d09eed-4525-494b-a5a7-1d1e8b570358"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("176bb127-2552-47a2-930f-f2ca8ea379f0"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("4e23c486-b467-4454-95b0-cced2943d907"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("5390d6ee-4110-4afe-8973-282da308c7e2"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("618a6b7e-93d5-4996-b436-863c09d81da7"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("655d042a-d318-406a-8412-ab7250c5fcaa"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("78fd8609-958a-404a-8e76-ad9620e6bb03"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("7cb5de95-bcb7-4b29-a905-a4948f684804"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("9b15f13d-4b31-4735-aa18-3fcacfa550fe"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("a8e541b1-398f-4f33-8290-bb6130bd81c8"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("aa5d87f3-cdc3-4631-a983-4d62834e4fb3"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("d21ca2bc-1dab-463e-8bb5-1512054a3ba7"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("f1559d9f-ca57-4ebe-994b-3b3313b11f54"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6fd0e1df-4e35-4be3-b3c3-26458c110627", "AQAAAAIAAYagAAAAEANbQ9kDKh7gcbF5PxJpe5rI1mwgNmc26iF1O2zEKBz7+Ira2EstsBT1Zbbii73nCA==", "080e05f5-060a-460d-a424-d8c3d9849b0f" });

            migrationBuilder.InsertData(
                table: "BookDefinitions",
                columns: new[] { "Id", "Author", "CoverImagePath", "Title" },
                values: new object[,]
                {
                    { new Guid("096e7f43-42f7-4aec-aae5-8150ca544988"), "Kornel Makuszyński", null, "Szatan z siódmej klasy" },
                    { new Guid("0d8b13ce-c312-4ab6-ade1-9f520572d3d1"), "Christopher Paolini", null, "Dziedzictwo" },
                    { new Guid("0f0d814a-3f87-44f5-9cec-0b7ea94fb457"), "Veronica Roth", null, "Niezgodna" },
                    { new Guid("20681464-4c2f-48e9-8298-1963d0ac0deb"), "George R.R. Martin", null, "Gra o tron (edycja ilustrowana)" },
                    { new Guid("2e5348d6-5033-45ce-99ca-1246864751d5"), "J.K. Rowling", null, "Harry Potter i więzień Azkabanu" },
                    { new Guid("4b2f9ce6-73b3-4140-ae76-dfce880a9ff6"), "Cassandra Clare", null, "Miasto upadłych aniołów" },
                    { new Guid("5c836eab-abf2-4621-8d62-3094a83a685c"), "Juliusz Słowacki", null, "Kordian" },
                    { new Guid("618e06c4-a6f5-42fd-85fa-6b1473fc7220"), "J.K. Rowling", null, "Harry Potter i Czara Ognia" },
                    { new Guid("6508fcf2-37a6-40ee-a0eb-422586cb27b8"), "William Shakespeare", null, "Romeo i Julia" },
                    { new Guid("69adfa84-daf3-4a3d-8ad5-53daaa26ce96"), "Camilla Läckberg", null, "Kamieniarz" },
                    { new Guid("6dae31df-8169-418a-aa5d-0877064a1df0"), "George R.R. Martin", null, "Nawałnica mieczy: Stal i śnieg" },
                    { new Guid("6dcdd6ed-f35c-4c82-8c28-79d2a9fece96"), "George R.R. Martin", null, "Starcie królów (edycja ilustrowana)" },
                    { new Guid("7d7b843f-53e7-411e-a59d-0e4e8a189187"), "Stieg Larsson", null, "Mężczyźni, którzy nienawidzą kobiet" },
                    { new Guid("86aa59e9-6e57-4a28-a688-dc2aa2c3b0e1"), "Andrzej Ziemiański", null, "Achaja. Tom I" },
                    { new Guid("8c1dfd9f-da3e-4acf-be48-4dc6b1802c79"), "Camilla Läckberg", null, "Księżniczka z lodu" },
                    { new Guid("8d717003-7ef7-4a4b-9e12-d5e7901873c3"), "Stanisław Wyspiański", null, "Wesele" },
                    { new Guid("9a61fa0e-cad5-4e65-b1e2-51f17e290a35"), "J.K. Rowling, Jack Thorne", null, "Harry Potter i Przeklęte Dziecko" },
                    { new Guid("9b10a2bc-ae1e-4650-9731-b4227d89a109"), "Camilla Läckberg", null, "Kaznodzieja" },
                    { new Guid("9dd9f9cf-858a-4520-b138-ed6f59fb9ca2"), "Johann Wolfgang von Goethe", null, "Cierpienia młodego Wertera" },
                    { new Guid("a9631293-7513-495b-a785-f0365a635d88"), "Andrzej Sapkowski", null, "Narrenturm" },
                    { new Guid("aaaf05df-6fae-4cdd-baff-41227de9ff81"), "J.K. Rowling", null, "Harry Potter i Komnata Tajemnic" },
                    { new Guid("b1af4309-530b-4dbd-8d3b-5a6918951efa"), "Władysław Stanisław Reymont", null, "Chłopi" },
                    { new Guid("bd510fa3-a160-4fe8-9821-8f987c68bebc"), "J.K. Rowling", null, "Harry Potter i Zakon Feniksa" },
                    { new Guid("bef8a1e0-6b79-4baa-87f9-b2d0ded980dc"), "J.K. Rowling", null, "Harry Potter i Kamień Filozoficzny" },
                    { new Guid("c79cb02b-2097-4c64-a9eb-2d953622afaf"), "J.K. Rowling", null, "Harry Potter i Książę Półkrwi" },
                    { new Guid("cb4a428b-6ebb-420e-aa6c-605a3e5de5a1"), "Juliusz Słowacki", null, "Balladyna" },
                    { new Guid("cde5099d-5d2f-40ee-b3d4-6f114e60d6a0"), "Dan Brown", null, "Inferno" },
                    { new Guid("d23360a4-e749-4ead-beb2-cacabac0a81b"), "Camilla Läckberg", null, "Ofiara losu" },
                    { new Guid("ef2c01fd-4e66-4f31-831d-2114abd85173"), "Camilla Läckberg", null, "Niemiecki bękart" },
                    { new Guid("ef875e6c-d757-4174-b6d0-943e91a54ea6"), "Jo Nesbø", null, "Człowiek nietoperz" }
                });

            migrationBuilder.InsertData(
                table: "Readers",
                columns: new[] { "Id", "City", "Code", "Name", "Street", "UserId" },
                values: new object[,]
                {
                    { new Guid("157f19f0-a66e-4161-b899-1ba14953519d"), "Poznań", "61-111", "Tomasz Rydz", "Garbary 1", null },
                    { new Guid("1957e470-5e20-46ed-9a4d-82ee39ec754e"), "Poznań", "61-311", "Jan Nowak", "Wieżowa 3", null },
                    { new Guid("6a2327b1-852d-441c-a3e6-95319def4f8f"), "Poznań", "61-111", "Aleksandra Mechrzycka", "Solna 2", null }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "BookDefinitionId", "Comment", "Status" },
                values: new object[,]
                {
                    { new Guid("0153d434-ef3a-40f1-8533-907dec68d164"), new Guid("20681464-4c2f-48e9-8298-1963d0ac0deb"), null, 0 },
                    { new Guid("04409baa-150f-41c7-a377-0b4604feb78b"), new Guid("0d8b13ce-c312-4ab6-ade1-9f520572d3d1"), null, 0 },
                    { new Guid("0b95f4be-e662-4bdf-b2d4-6b0f4afd8764"), new Guid("20681464-4c2f-48e9-8298-1963d0ac0deb"), null, 0 },
                    { new Guid("0dd4f40d-7d4d-4c48-8f76-6617c06837af"), new Guid("4b2f9ce6-73b3-4140-ae76-dfce880a9ff6"), null, 2 },
                    { new Guid("0f270e07-4c82-4b53-bc0d-44e5c4a0f65e"), new Guid("4b2f9ce6-73b3-4140-ae76-dfce880a9ff6"), null, 1 },
                    { new Guid("1888c887-81e1-4046-b280-72baa3d22ec7"), new Guid("6dcdd6ed-f35c-4c82-8c28-79d2a9fece96"), null, 2 },
                    { new Guid("1b54954e-a65f-4b3e-a055-e512a94ba937"), new Guid("bef8a1e0-6b79-4baa-87f9-b2d0ded980dc"), null, 0 },
                    { new Guid("1bcbf03f-169b-4e00-8fe0-eb4ed205460f"), new Guid("ef2c01fd-4e66-4f31-831d-2114abd85173"), null, 2 },
                    { new Guid("1c283061-3f71-4237-993d-cade422877ed"), new Guid("5c836eab-abf2-4621-8d62-3094a83a685c"), null, 2 },
                    { new Guid("1d761150-d68e-4a7d-b1eb-527a83369f41"), new Guid("9a61fa0e-cad5-4e65-b1e2-51f17e290a35"), null, 1 },
                    { new Guid("1efc4ca5-f1b4-480e-9609-8288fd159293"), new Guid("69adfa84-daf3-4a3d-8ad5-53daaa26ce96"), null, 2 },
                    { new Guid("1f36fe2f-3e7b-48d0-b3cb-836839b2f753"), new Guid("0d8b13ce-c312-4ab6-ade1-9f520572d3d1"), null, 2 },
                    { new Guid("2155809f-8d7b-4b54-b718-f24d0ab3ddec"), new Guid("0f0d814a-3f87-44f5-9cec-0b7ea94fb457"), null, 0 },
                    { new Guid("22299b68-0f32-4a1f-98b3-fdca4e2cab03"), new Guid("ef875e6c-d757-4174-b6d0-943e91a54ea6"), null, 0 },
                    { new Guid("224feaff-43f4-4366-975b-75c2d689a76f"), new Guid("7d7b843f-53e7-411e-a59d-0e4e8a189187"), null, 1 },
                    { new Guid("22f2196a-e666-43f4-856c-f79f566b3347"), new Guid("5c836eab-abf2-4621-8d62-3094a83a685c"), null, 0 },
                    { new Guid("2959712c-0ae7-4625-9773-0c08deadd084"), new Guid("7d7b843f-53e7-411e-a59d-0e4e8a189187"), null, 0 },
                    { new Guid("2a534249-c38d-4280-8068-2102b4124406"), new Guid("6dcdd6ed-f35c-4c82-8c28-79d2a9fece96"), null, 0 },
                    { new Guid("2a6e605b-1265-4720-8f70-81e1dae8825c"), new Guid("86aa59e9-6e57-4a28-a688-dc2aa2c3b0e1"), null, 2 },
                    { new Guid("2d3287f3-fdf1-4e70-b2f6-3c7efec08de4"), new Guid("0f0d814a-3f87-44f5-9cec-0b7ea94fb457"), null, 2 },
                    { new Guid("2eb9569f-751b-4d04-b3cd-aa24d5584d90"), new Guid("6dae31df-8169-418a-aa5d-0877064a1df0"), null, 1 },
                    { new Guid("32d08c81-aa38-48a0-94ec-f6627d14fc1c"), new Guid("7d7b843f-53e7-411e-a59d-0e4e8a189187"), null, 2 },
                    { new Guid("36740fc1-c198-4283-b984-42bb905a8a8e"), new Guid("9b10a2bc-ae1e-4650-9731-b4227d89a109"), null, 2 },
                    { new Guid("383d9f77-1527-4a84-9c33-7f8d034c70e7"), new Guid("9b10a2bc-ae1e-4650-9731-b4227d89a109"), null, 1 },
                    { new Guid("3a35d4f1-ea6a-47fb-bb07-9bc87cc47df5"), new Guid("5c836eab-abf2-4621-8d62-3094a83a685c"), null, 1 },
                    { new Guid("40c74e46-0181-4ea4-b928-2ed3440ff77e"), new Guid("6dcdd6ed-f35c-4c82-8c28-79d2a9fece96"), null, 1 },
                    { new Guid("418d1f60-40b6-4ca7-9beb-83efdf647117"), new Guid("b1af4309-530b-4dbd-8d3b-5a6918951efa"), null, 0 },
                    { new Guid("4648f33e-c68c-4a9a-894b-e00a81ef5244"), new Guid("0f0d814a-3f87-44f5-9cec-0b7ea94fb457"), null, 1 },
                    { new Guid("488f3e25-4c93-4c73-8936-0e9fe2293ec6"), new Guid("cb4a428b-6ebb-420e-aa6c-605a3e5de5a1"), null, 1 },
                    { new Guid("4cd7e92e-1fd6-4ff1-8751-41b42fd499b9"), new Guid("096e7f43-42f7-4aec-aae5-8150ca544988"), null, 1 },
                    { new Guid("4e651f9f-8820-4fd2-afb8-1379b242d797"), new Guid("5c836eab-abf2-4621-8d62-3094a83a685c"), null, 0 },
                    { new Guid("4fa6c3f0-8eb8-4fea-87e9-a6e254a0c7b9"), new Guid("aaaf05df-6fae-4cdd-baff-41227de9ff81"), null, 2 },
                    { new Guid("527a3be6-1539-4522-9a4a-ab43cc9785d8"), new Guid("ef2c01fd-4e66-4f31-831d-2114abd85173"), null, 2 },
                    { new Guid("5434d5f9-59e9-45ae-b60e-def591915f9e"), new Guid("4b2f9ce6-73b3-4140-ae76-dfce880a9ff6"), null, 0 },
                    { new Guid("5711f618-c111-447c-a0ec-2e2c47de3f5c"), new Guid("8d717003-7ef7-4a4b-9e12-d5e7901873c3"), null, 1 },
                    { new Guid("596dbd64-2d93-40b0-91a6-e8b55618b979"), new Guid("0d8b13ce-c312-4ab6-ade1-9f520572d3d1"), null, 2 },
                    { new Guid("59dec810-5a4e-481e-b6d8-1e4e979f6d82"), new Guid("cde5099d-5d2f-40ee-b3d4-6f114e60d6a0"), null, 0 },
                    { new Guid("5b3707b6-6f4e-4b28-8625-7bbd3c7e35d2"), new Guid("cde5099d-5d2f-40ee-b3d4-6f114e60d6a0"), null, 1 },
                    { new Guid("5d1d6d82-9e97-486f-a4f0-9bb2eed129ad"), new Guid("6508fcf2-37a6-40ee-a0eb-422586cb27b8"), null, 1 },
                    { new Guid("5efba376-cc0b-4eb4-b5e6-705c7c5aa3d2"), new Guid("0f0d814a-3f87-44f5-9cec-0b7ea94fb457"), null, 2 },
                    { new Guid("5f49739f-50cf-479a-a1f5-03b1ee1d4d0b"), new Guid("69adfa84-daf3-4a3d-8ad5-53daaa26ce96"), null, 0 },
                    { new Guid("683b8066-c9ad-4f48-b19d-40f240a455a7"), new Guid("0d8b13ce-c312-4ab6-ade1-9f520572d3d1"), null, 2 },
                    { new Guid("68da4603-2f36-49bf-aef2-6d5620877571"), new Guid("4b2f9ce6-73b3-4140-ae76-dfce880a9ff6"), null, 0 },
                    { new Guid("7304d5b9-1639-4103-9e30-a091284be2c9"), new Guid("8d717003-7ef7-4a4b-9e12-d5e7901873c3"), null, 2 },
                    { new Guid("740ff527-8fe4-42e2-a1c6-8760934ba25c"), new Guid("2e5348d6-5033-45ce-99ca-1246864751d5"), null, 1 },
                    { new Guid("7645beea-eefa-482a-9661-b3a272029161"), new Guid("6dcdd6ed-f35c-4c82-8c28-79d2a9fece96"), null, 0 },
                    { new Guid("76abbd49-55ef-4c31-8d72-9e95244b699d"), new Guid("0d8b13ce-c312-4ab6-ade1-9f520572d3d1"), null, 0 },
                    { new Guid("78ac340c-2c1b-45e6-80be-0e38a450adcf"), new Guid("0f0d814a-3f87-44f5-9cec-0b7ea94fb457"), null, 2 },
                    { new Guid("78adbbff-4fd8-4fa6-be31-205035e14026"), new Guid("d23360a4-e749-4ead-beb2-cacabac0a81b"), null, 1 },
                    { new Guid("7aacb625-7458-4cac-9e19-a29285fbe3b2"), new Guid("0d8b13ce-c312-4ab6-ade1-9f520572d3d1"), null, 1 },
                    { new Guid("809163f6-0376-4882-bf72-8af1c3a28a53"), new Guid("aaaf05df-6fae-4cdd-baff-41227de9ff81"), null, 0 },
                    { new Guid("87a00a22-42fa-4c40-93e3-6ef37ffa757f"), new Guid("20681464-4c2f-48e9-8298-1963d0ac0deb"), null, 0 },
                    { new Guid("87ea4b18-ae43-4df2-988e-0475c640b174"), new Guid("9a61fa0e-cad5-4e65-b1e2-51f17e290a35"), null, 0 },
                    { new Guid("8f68c8c3-f03d-4d84-9e66-a7be4283601f"), new Guid("b1af4309-530b-4dbd-8d3b-5a6918951efa"), null, 2 },
                    { new Guid("944164c6-b86f-41b7-97d6-f743c2b92443"), new Guid("6dcdd6ed-f35c-4c82-8c28-79d2a9fece96"), null, 2 },
                    { new Guid("959ce6b3-9571-46b3-9353-c260f856b049"), new Guid("9a61fa0e-cad5-4e65-b1e2-51f17e290a35"), null, 2 },
                    { new Guid("97072cef-9bcd-4265-ba30-0a0fd78c6436"), new Guid("7d7b843f-53e7-411e-a59d-0e4e8a189187"), null, 0 },
                    { new Guid("98b492ed-d956-4d8c-9ad3-c3e2181d9f97"), new Guid("2e5348d6-5033-45ce-99ca-1246864751d5"), null, 0 },
                    { new Guid("9d50d65d-dec7-4409-8991-a0472acd68b9"), new Guid("20681464-4c2f-48e9-8298-1963d0ac0deb"), null, 0 },
                    { new Guid("9e8d0c3a-4988-4b86-8da6-0ef8d84df9cd"), new Guid("6dae31df-8169-418a-aa5d-0877064a1df0"), null, 0 },
                    { new Guid("a0c9f9d3-8915-41ab-a47c-c951f9c330ec"), new Guid("4b2f9ce6-73b3-4140-ae76-dfce880a9ff6"), null, 0 },
                    { new Guid("a3c52fd3-1622-4761-ad7a-b87ab4d693d8"), new Guid("69adfa84-daf3-4a3d-8ad5-53daaa26ce96"), null, 0 },
                    { new Guid("a5545a5d-c0ba-4018-8a7f-ef2171d3bd19"), new Guid("b1af4309-530b-4dbd-8d3b-5a6918951efa"), null, 2 },
                    { new Guid("a5bd34c9-cad1-4cdd-8d4b-81bda92ec2c8"), new Guid("0d8b13ce-c312-4ab6-ade1-9f520572d3d1"), null, 0 },
                    { new Guid("a5f89727-f36d-493b-b8a6-1107ea9bbaa8"), new Guid("ef2c01fd-4e66-4f31-831d-2114abd85173"), null, 1 },
                    { new Guid("a6a6d974-5335-43d8-82dc-ddd5569ef9bd"), new Guid("6dcdd6ed-f35c-4c82-8c28-79d2a9fece96"), null, 2 },
                    { new Guid("a8281dc2-5a2e-4ef9-a8b1-be6f197e59f0"), new Guid("6dae31df-8169-418a-aa5d-0877064a1df0"), null, 2 },
                    { new Guid("a8344ecf-a6b7-44b6-968f-3be73b62bfcf"), new Guid("bef8a1e0-6b79-4baa-87f9-b2d0ded980dc"), null, 2 },
                    { new Guid("a91c046b-d7f9-4a3f-b79f-240a298762e9"), new Guid("6dcdd6ed-f35c-4c82-8c28-79d2a9fece96"), null, 1 },
                    { new Guid("b1987401-f716-4f7a-8435-c677e29d8f4b"), new Guid("ef875e6c-d757-4174-b6d0-943e91a54ea6"), null, 0 },
                    { new Guid("b5e332e8-5f46-4e25-8fb4-73a3d61d6782"), new Guid("9dd9f9cf-858a-4520-b138-ed6f59fb9ca2"), null, 1 },
                    { new Guid("b6d81bdc-ec66-408b-bf17-bab396968af8"), new Guid("2e5348d6-5033-45ce-99ca-1246864751d5"), null, 0 },
                    { new Guid("b8a0724b-9651-4ac7-9eee-f46e30b14850"), new Guid("ef875e6c-d757-4174-b6d0-943e91a54ea6"), null, 2 },
                    { new Guid("ba5bd906-a9ed-49eb-bd7a-f914e9f36226"), new Guid("d23360a4-e749-4ead-beb2-cacabac0a81b"), null, 1 },
                    { new Guid("bb1ab2a2-abf2-459e-814b-e6a828db882a"), new Guid("b1af4309-530b-4dbd-8d3b-5a6918951efa"), null, 0 },
                    { new Guid("bcee4c61-51c3-49a8-ac8e-03dd5f970ec8"), new Guid("5c836eab-abf2-4621-8d62-3094a83a685c"), null, 2 },
                    { new Guid("c28fdcfc-328c-4724-9eaf-6b5e094c12e7"), new Guid("7d7b843f-53e7-411e-a59d-0e4e8a189187"), null, 2 },
                    { new Guid("c39a4265-485c-45c5-ab7b-1dadb839c19f"), new Guid("c79cb02b-2097-4c64-a9eb-2d953622afaf"), null, 0 },
                    { new Guid("cb801696-263e-4740-957a-ce024c27b4cf"), new Guid("618e06c4-a6f5-42fd-85fa-6b1473fc7220"), null, 0 },
                    { new Guid("d09c1bde-86f3-4729-9fda-b2d32ea4f432"), new Guid("d23360a4-e749-4ead-beb2-cacabac0a81b"), null, 2 },
                    { new Guid("d1caa2a1-c28d-486d-95bf-0a4bf9ac1cbb"), new Guid("aaaf05df-6fae-4cdd-baff-41227de9ff81"), null, 1 },
                    { new Guid("d83738fa-2dff-430d-b6b2-4e4444f15ab2"), new Guid("ef875e6c-d757-4174-b6d0-943e91a54ea6"), null, 1 },
                    { new Guid("d962a2bc-7dc6-431c-a778-0aa2853ce979"), new Guid("69adfa84-daf3-4a3d-8ad5-53daaa26ce96"), null, 0 },
                    { new Guid("da3e3e65-83b8-4cee-95f3-429e6a5c5c3d"), new Guid("aaaf05df-6fae-4cdd-baff-41227de9ff81"), null, 2 },
                    { new Guid("ddc34418-4987-45c2-a064-f377ccde17f0"), new Guid("aaaf05df-6fae-4cdd-baff-41227de9ff81"), null, 1 },
                    { new Guid("de13e8a3-2d58-45f5-baa4-ffccbb8f11d8"), new Guid("0f0d814a-3f87-44f5-9cec-0b7ea94fb457"), null, 0 },
                    { new Guid("e0557675-d411-4161-b28e-05e14d61bb76"), new Guid("6508fcf2-37a6-40ee-a0eb-422586cb27b8"), null, 0 },
                    { new Guid("e0824375-1ad0-4a96-9dac-a71c7017773d"), new Guid("8c1dfd9f-da3e-4acf-be48-4dc6b1802c79"), null, 2 },
                    { new Guid("e5331303-2952-42e5-960f-47a82e32c697"), new Guid("4b2f9ce6-73b3-4140-ae76-dfce880a9ff6"), null, 2 },
                    { new Guid("e5e9745c-aaa6-445e-abab-3a1e6fc37d72"), new Guid("618e06c4-a6f5-42fd-85fa-6b1473fc7220"), null, 1 },
                    { new Guid("e91e0c01-65f6-4aef-b2e0-c0e3522d6290"), new Guid("8d717003-7ef7-4a4b-9e12-d5e7901873c3"), null, 1 },
                    { new Guid("e9e5fd26-1c25-40ef-a676-5e23456f187f"), new Guid("9dd9f9cf-858a-4520-b138-ed6f59fb9ca2"), null, 0 },
                    { new Guid("ea14453c-9f94-4d0e-9b93-b2f5b9dbc8c2"), new Guid("0d8b13ce-c312-4ab6-ade1-9f520572d3d1"), null, 0 },
                    { new Guid("edc5d704-e409-4610-b79e-e69136e325d8"), new Guid("b1af4309-530b-4dbd-8d3b-5a6918951efa"), null, 2 },
                    { new Guid("f0c9f6e4-2800-4bf0-9a13-a53462881f7f"), new Guid("2e5348d6-5033-45ce-99ca-1246864751d5"), null, 1 },
                    { new Guid("f16077b4-f607-4fd0-9c39-4c0af2282777"), new Guid("4b2f9ce6-73b3-4140-ae76-dfce880a9ff6"), null, 0 },
                    { new Guid("f1bd67fb-6ff2-47bf-a685-e6585ed593c2"), new Guid("c79cb02b-2097-4c64-a9eb-2d953622afaf"), null, 0 },
                    { new Guid("f47d6cda-94f8-49f5-a3ea-c060e1a9a4b8"), new Guid("69adfa84-daf3-4a3d-8ad5-53daaa26ce96"), null, 1 },
                    { new Guid("fad1f62a-68a2-4d53-b70a-5af8a6d2640b"), new Guid("8c1dfd9f-da3e-4acf-be48-4dc6b1802c79"), null, 0 },
                    { new Guid("fe176798-19cb-4e13-81a0-4ca6336e8aa5"), new Guid("6dcdd6ed-f35c-4c82-8c28-79d2a9fece96"), null, 2 }
                });

            migrationBuilder.InsertData(
                table: "Borrowings",
                columns: new[] { "Id", "BookId", "BorrowDate", "ReaderId", "ReturnDate" },
                values: new object[,]
                {
                    { new Guid("05b4f074-d43b-44c4-bfed-a35ad8d64470"), new Guid("488f3e25-4c93-4c73-8936-0e9fe2293ec6"), new DateTime(2025, 4, 30, 0, 0, 0, 0, DateTimeKind.Local), new Guid("1957e470-5e20-46ed-9a4d-82ee39ec754e"), new DateTime(2025, 6, 29, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("0a0fb03a-f762-472f-9741-714cc55d5911"), new Guid("7aacb625-7458-4cac-9e19-a29285fbe3b2"), new DateTime(2025, 5, 5, 0, 0, 0, 0, DateTimeKind.Local), new Guid("6a2327b1-852d-441c-a3e6-95319def4f8f"), new DateTime(2025, 7, 4, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("1aa231bd-a902-43e9-9858-28111ff56ccb"), new Guid("4648f33e-c68c-4a9a-894b-e00a81ef5244"), new DateTime(2025, 5, 13, 0, 0, 0, 0, DateTimeKind.Local), new Guid("5d31a024-4e84-4f5e-b86b-04b10d79559e"), new DateTime(2025, 7, 12, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("2423e7e9-292e-48ce-8d52-b87d32c4e4ce"), new Guid("5b3707b6-6f4e-4b28-8625-7bbd3c7e35d2"), new DateTime(2025, 5, 7, 0, 0, 0, 0, DateTimeKind.Local), new Guid("6a2327b1-852d-441c-a3e6-95319def4f8f"), new DateTime(2025, 7, 6, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("2803211d-ad45-4e57-aa5a-b61f54dc2e29"), new Guid("40c74e46-0181-4ea4-b928-2ed3440ff77e"), new DateTime(2025, 5, 4, 0, 0, 0, 0, DateTimeKind.Local), new Guid("1957e470-5e20-46ed-9a4d-82ee39ec754e"), new DateTime(2025, 7, 3, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("37aecbef-1ece-4ad2-b02f-4deb3e7672b1"), new Guid("2eb9569f-751b-4d04-b3cd-aa24d5584d90"), new DateTime(2025, 5, 4, 0, 0, 0, 0, DateTimeKind.Local), new Guid("6a2327b1-852d-441c-a3e6-95319def4f8f"), new DateTime(2025, 7, 3, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("408fc73b-ecf0-48aa-9f6e-2a71d8eb2978"), new Guid("740ff527-8fe4-42e2-a1c6-8760934ba25c"), new DateTime(2025, 5, 4, 0, 0, 0, 0, DateTimeKind.Local), new Guid("1957e470-5e20-46ed-9a4d-82ee39ec754e"), new DateTime(2025, 7, 3, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("48126097-ab80-4606-9f3a-b3e1c4a09bb2"), new Guid("5d1d6d82-9e97-486f-a4f0-9bb2eed129ad"), new DateTime(2025, 5, 7, 0, 0, 0, 0, DateTimeKind.Local), new Guid("5d31a024-4e84-4f5e-b86b-04b10d79559e"), new DateTime(2025, 7, 6, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("59ff84ab-a5e5-4086-bbda-4b20c6723c48"), new Guid("a91c046b-d7f9-4a3f-b79f-240a298762e9"), new DateTime(2025, 5, 3, 0, 0, 0, 0, DateTimeKind.Local), new Guid("5d31a024-4e84-4f5e-b86b-04b10d79559e"), new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("5a1830fd-9167-4069-98c9-1a633fa72ca1"), new Guid("224feaff-43f4-4366-975b-75c2d689a76f"), new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Local), new Guid("1957e470-5e20-46ed-9a4d-82ee39ec754e"), new DateTime(2025, 6, 30, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("5f2b17b0-42d8-4168-a87b-619263f7f381"), new Guid("d83738fa-2dff-430d-b6b2-4e4444f15ab2"), new DateTime(2025, 5, 8, 0, 0, 0, 0, DateTimeKind.Local), new Guid("157f19f0-a66e-4161-b899-1ba14953519d"), new DateTime(2025, 7, 7, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("726a1619-a8e7-4c2e-9482-db30c0cb9390"), new Guid("78adbbff-4fd8-4fa6-be31-205035e14026"), new DateTime(2025, 4, 30, 0, 0, 0, 0, DateTimeKind.Local), new Guid("5d31a024-4e84-4f5e-b86b-04b10d79559e"), new DateTime(2025, 6, 29, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("91b18133-9de1-4b7c-9e89-973016d5c9d4"), new Guid("ba5bd906-a9ed-49eb-bd7a-f914e9f36226"), new DateTime(2025, 5, 3, 0, 0, 0, 0, DateTimeKind.Local), new Guid("157f19f0-a66e-4161-b899-1ba14953519d"), new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("91fd4ad7-ff72-49e8-91bc-2593b99f3017"), new Guid("d1caa2a1-c28d-486d-95bf-0a4bf9ac1cbb"), new DateTime(2025, 5, 2, 0, 0, 0, 0, DateTimeKind.Local), new Guid("6a2327b1-852d-441c-a3e6-95319def4f8f"), new DateTime(2025, 7, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("aef1dca7-5428-4bcd-b774-3a7efd0d0851"), new Guid("a5f89727-f36d-493b-b8a6-1107ea9bbaa8"), new DateTime(2025, 5, 9, 0, 0, 0, 0, DateTimeKind.Local), new Guid("6a2327b1-852d-441c-a3e6-95319def4f8f"), new DateTime(2025, 7, 8, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("b7cfbb28-08f0-4170-823a-046e37875bbe"), new Guid("4cd7e92e-1fd6-4ff1-8751-41b42fd499b9"), new DateTime(2025, 5, 13, 0, 0, 0, 0, DateTimeKind.Local), new Guid("5d31a024-4e84-4f5e-b86b-04b10d79559e"), new DateTime(2025, 7, 12, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("bc29121f-7542-4ac3-a877-2c1b15007430"), new Guid("e5e9745c-aaa6-445e-abab-3a1e6fc37d72"), new DateTime(2025, 5, 5, 0, 0, 0, 0, DateTimeKind.Local), new Guid("1957e470-5e20-46ed-9a4d-82ee39ec754e"), new DateTime(2025, 7, 4, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("cc6e68ad-9c4a-4627-888e-c271aabadbb4"), new Guid("3a35d4f1-ea6a-47fb-bb07-9bc87cc47df5"), new DateTime(2025, 5, 5, 0, 0, 0, 0, DateTimeKind.Local), new Guid("157f19f0-a66e-4161-b899-1ba14953519d"), new DateTime(2025, 7, 4, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("d1263a07-dec9-4991-884d-5bb442d90bfa"), new Guid("ddc34418-4987-45c2-a064-f377ccde17f0"), new DateTime(2025, 5, 11, 0, 0, 0, 0, DateTimeKind.Local), new Guid("1957e470-5e20-46ed-9a4d-82ee39ec754e"), new DateTime(2025, 7, 10, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("da2dbd96-59ef-47a8-8fc1-a881cc999e88"), new Guid("383d9f77-1527-4a84-9c33-7f8d034c70e7"), new DateTime(2025, 5, 14, 0, 0, 0, 0, DateTimeKind.Local), new Guid("1957e470-5e20-46ed-9a4d-82ee39ec754e"), new DateTime(2025, 7, 13, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("dbb39616-aeb6-455c-83c2-8df7202f9a9a"), new Guid("f47d6cda-94f8-49f5-a3ea-c060e1a9a4b8"), new DateTime(2025, 5, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("1957e470-5e20-46ed-9a4d-82ee39ec754e"), new DateTime(2025, 7, 11, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("ec2fc5b0-177a-4453-9e36-95836dedcc01"), new Guid("5711f618-c111-447c-a0ec-2e2c47de3f5c"), new DateTime(2025, 5, 10, 0, 0, 0, 0, DateTimeKind.Local), new Guid("6a2327b1-852d-441c-a3e6-95319def4f8f"), new DateTime(2025, 7, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("ed0d3401-202a-4573-8102-b8da6a560f44"), new Guid("f0c9f6e4-2800-4bf0-9a13-a53462881f7f"), new DateTime(2025, 4, 30, 0, 0, 0, 0, DateTimeKind.Local), new Guid("6a2327b1-852d-441c-a3e6-95319def4f8f"), new DateTime(2025, 6, 29, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("ef0482f7-e1fc-46cf-914d-63e4ab6aa375"), new Guid("e91e0c01-65f6-4aef-b2e0-c0e3522d6290"), new DateTime(2025, 5, 5, 0, 0, 0, 0, DateTimeKind.Local), new Guid("5d31a024-4e84-4f5e-b86b-04b10d79559e"), new DateTime(2025, 7, 4, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("ef595e45-f755-4aaa-8b3d-a662cd059bc9"), new Guid("0f270e07-4c82-4b53-bc0d-44e5c4a0f65e"), new DateTime(2025, 5, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("157f19f0-a66e-4161-b899-1ba14953519d"), new DateTime(2025, 7, 11, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("f1d740ce-d4aa-4275-940d-9ce6ada615e5"), new Guid("b5e332e8-5f46-4e25-8fb4-73a3d61d6782"), new DateTime(2025, 4, 30, 0, 0, 0, 0, DateTimeKind.Local), new Guid("157f19f0-a66e-4161-b899-1ba14953519d"), new DateTime(2025, 6, 29, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("f862bbc9-55b5-4182-bda9-f3b48e087da1"), new Guid("1d761150-d68e-4a7d-b1eb-527a83369f41"), new DateTime(2025, 5, 14, 0, 0, 0, 0, DateTimeKind.Local), new Guid("157f19f0-a66e-4161-b899-1ba14953519d"), new DateTime(2025, 7, 13, 0, 0, 0, 0, DateTimeKind.Local) }
                });
        }
    }
}
