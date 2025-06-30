using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LibSys.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddCoverImagePathToBooks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("3e0d0ba3-8d04-4700-91bf-f3e3d78129ef"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("c72c0bbb-32eb-4676-a628-2b1aea7e434b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("04458325-54c3-4f25-b16e-5e8f0fce2562"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("19a2c0cf-b56a-4cc6-9d55-cce66a648bd2"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("217e2ead-b9de-4a38-a2ab-995f9515a8b7"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("29a2798b-2d43-429c-b232-704e0e42a61e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2bafac4d-096e-493a-be81-b862350189e7"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("30dc1b8c-6f90-48ba-8434-dcd5be4d8276"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("3273742c-d607-4b81-ae55-3d65b3941f9c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("3dedc88b-8f8b-403e-9468-e782adfe22ef"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("3df99c7e-dc10-420d-ac5c-9547f930c9bc"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("428d8f2a-4f09-4f20-bff6-cd9de70e8204"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("42aae123-5f81-439c-b85c-86b194f5ac84"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("435579ed-f57d-45d5-bfc2-41aeaa03b0bc"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("461e28c6-ed59-4055-80a7-a34730a367ba"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4c2cbb8e-f1b7-4bc8-b5b6-0b64a62ae510"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4d2cc9be-bb09-44ed-9f37-0e9ef3466926"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("522672d0-5c49-45a0-8533-142c81cfe905"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("53e62ef4-f0fe-419b-8e02-34f920862cbb"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("5694a295-f5ea-46ec-bd54-8f625aa4707c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("57650987-400b-4a05-9314-472676a3e68f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("5d7826ed-31e5-4ae8-93f4-ebd17dd2ff53"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("687f20d1-fcb5-40d4-8261-96469633348a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("68dd801b-29a6-49e0-9615-1116b02d4f29"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("69a4237b-f0f7-46f3-84c7-08893d583391"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("706c489e-ba97-47d9-b65b-1c131a39acab"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("73d4d398-6788-4b58-87ff-dfdc5b977dc9"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("740f47fe-fd84-4362-aeee-0466b0361aa9"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("7748142b-c549-45af-b7e9-7857acf63d63"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("77d2ebd2-1446-448f-8099-4a45f20f0ffb"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("7a0a4ec2-dad5-41e5-9702-0b942b0043dd"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("812d4f76-5d7e-4801-bb46-826f0521fa65"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("818d1105-03f3-4ea0-adcd-516f3f413842"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("872ff021-0db3-4d31-be94-58d48b8be986"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("874c32cd-7e95-479e-b709-c044b3a43896"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8e956fed-01da-421c-8ea4-790d0c14bffa"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("97fd701a-3ea5-4420-be7d-0f0d00f31958"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("98ddb6e6-db0b-4066-8ac6-d84b0453856a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9a42a451-c4a1-4a6c-934a-3ad5315b0bc8"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9b61bcd3-8c89-4c6e-bbd6-f983861c0a98"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9cdcb892-7152-4032-a402-a9ba267b3b02"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a26434dd-0bce-44c6-b47d-7fa81425e9a6"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a404267e-8bbf-4d7c-a099-35583479fefa"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a9ef1d77-4272-49b4-aa5b-77a0b0dbee80"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ab9d7520-8bdc-4e8a-8e1c-597d8678b846"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b0572f4e-2e8d-41d8-8bb1-3711f72a58a8"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b0c59b6f-3213-4ce4-adc6-f8450208d0ab"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b2d99989-50e6-4a17-a9ae-a7480e127f53"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b9bc4d99-c0a1-4a67-85f8-b276d406b8f9"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b9ff10df-1674-4c96-8a0b-2c6a5790f58a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("bda065a6-57f6-4a7e-9d8e-5a976fa1d57f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("cf817901-5d82-4394-ba7c-f89466bf2384"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d2159c46-4ed0-492f-b189-d16d28cac813"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d3e80909-4838-4a08-bf68-917e7d5de7af"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d6946216-8d7c-47d0-b272-d780d3b033dc"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d6967918-e933-4539-9bdf-0abe2d95b0a7"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d8cd43f1-c23f-4a5c-98d6-ab2ffd9ac952"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d91ae0ee-5b54-43cb-8070-1b8da1b3175c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e120d5f1-f62d-41ad-bbe9-b3b482575115"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e20c0a42-43ce-4271-a01f-9935df0aa371"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e8321ee2-91dd-470f-aba4-6d3195d24b1a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e8377740-6ec2-43fd-8ee8-70508351a088"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e8744ae4-f299-4ff8-ada8-e23f90845ec3"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e8d38cf2-f461-46e8-a4b2-6582436ec489"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e936176e-a4f6-43d4-a060-7e164013496d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("eac4e213-434d-4dd1-ae8d-90b4cd8a4b7f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ec8deff1-7591-4845-920a-2cafb3d5c461"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("eeec2a56-72c0-46c1-8b3b-e61450030ead"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f2adcd4e-f13c-4dfd-84e9-f4da752a3e05"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f46924fb-f28f-4374-8175-3f50ee53edb3"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("fad3d981-ae34-4af0-8458-f0a9b1dcfc30"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("fb6d47ec-fa02-4573-a76d-daba68e75860"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("09803399-58b7-4fa8-a1a9-c7167b6d3615"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("0fe4a8e2-569f-4cf1-bf79-0469b3a1b1fb"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("115deabf-638d-486c-bbab-ec0455efa5d3"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("1474b77c-c36f-4958-954b-5a34bd490776"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("17caf637-4546-4c3f-aa46-d16f5a638818"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("255062c4-802b-42d2-b56e-a8ce547a9916"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("2c762346-63bf-4c24-857c-8ce60239520f"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("2d826f51-fa20-449e-ac91-cf6a80b767f6"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("2e818f47-8877-441e-825c-27898feeda23"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("370afe36-391d-4138-a401-bd4870cdbd06"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("39745302-ad15-42df-b432-bc3c16081ea0"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("3a545999-e75b-4669-8efd-d9d0efe00964"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("4ef8dc2d-7f9a-4c36-b3fe-257b26d8621f"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("5b8dea20-072e-45c8-b753-07cbd6f70f13"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("6cf8901a-ea30-445b-a1aa-b2b1e5a6e98a"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("6df44fe1-0f6a-4dad-b679-0d9f74ae70b1"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("7f3613da-8b4f-4878-bf93-ffc15f0e06d3"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("853ceaeb-dcdc-4195-b79c-b5630df37f07"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("8d0dea4d-196c-4896-b64a-f0db40456284"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("8d71d320-91e6-46be-b208-8f2672bc4ceb"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("904038c7-5b75-4c6f-aa69-ed2b15d0d3e3"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("a4d17889-a4b3-40c9-a5d1-fc61b6717785"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("a781913f-969b-4331-808b-1099106e3699"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("b1f26b4a-437d-45ca-98fb-89820a02dd5a"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("b3f3c7bf-a153-4c02-b8ab-e498e142523f"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("ba6494fa-5df5-4422-a064-0d134f70225a"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("c90959bb-766c-4fd9-8b49-61fbce52b78b"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("cda706c8-5201-4206-ab81-f107eab02844"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("e1a1f9af-dc08-4366-a216-9e06cd0d891c"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("e8974f85-31a8-4569-9422-c694fa0ecc18"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("0a097611-ce71-4a35-8b70-e3e855a70ae7"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("0d0f72a9-d358-4283-aca5-15811ed0aeb8"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("2ba37673-a6e9-4539-9f68-24921544db84"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("2eb18b3a-eb70-4984-b20e-eba3082dd5c3"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("7132bc9d-aec5-419a-8594-a427b49a0393"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("8aa0f520-e3aa-4838-b4b8-54b3fda386a3"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("e1a08da5-0c3e-4f4c-8f75-3fde7ef6c9b7"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("079638cb-6d07-4ad6-963f-56cfccee80c7"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1102a15c-bc66-4291-ac12-8069ef385393"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("16aa5a85-50e6-4b37-b310-1ca8ffabd155"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1ca457bb-65a3-4368-87a7-cfb4c60fb149"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("20ec3e8b-8c3b-4dee-9da7-093579c71a4f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("21c536c4-494c-44f1-84c5-be8fe6145b58"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("28e868af-842e-43f2-8a45-447f8e14031c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("3550d8b6-c72e-47a8-bf8c-3982f945105d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4746d247-4e52-40e2-8d46-e9c97fd9748d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("52f38433-da32-445e-aeed-769c21c5e6de"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("6c3cc738-65cc-4c63-9cfd-8bdcae010a84"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("7006ca97-25b0-4d67-a7a4-b91bc6fc4d16"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("77b9510b-5310-4a1f-b5ad-3b310fc432ea"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("78587f17-5dec-4ae4-b4f0-216b0e1866ed"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("7d977b68-ea78-4217-b6a4-a16afdc6b18c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("80c3cac4-9b75-431f-93dd-12b3e480281d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("85c515c7-3ae7-4845-b5ab-043eb413bd22"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8600bd80-5d2f-4a26-93c9-8ad950b4f87e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("86a88a4e-d4aa-44c7-9a56-e0253efc60fc"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9aa721a3-8746-43c9-b1eb-6476d2dacacc"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a4263179-198f-471a-b7f5-747e2aa05c50"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a77ab981-9426-40c4-8289-735bdca7ef3f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a908b462-f860-42eb-aba6-f1cbbaab0989"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b64e0711-4ac0-4cf9-aa4d-9e5d2e6167ac"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("bbc5b71a-f9c8-4bc4-928e-7cf043fbcac5"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c2c0d065-3029-4971-ac6b-4bd326256bbe"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ce1cd65c-8361-47d1-84c7-f96e6fbc3ed3"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d77275d7-fc21-4288-b44b-28d845cc4a75"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e29817aa-3989-4831-903b-450f638e174e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f6cdb6ed-9555-46ba-b8d1-c548c2c9e0ab"));

            migrationBuilder.DeleteData(
                table: "Readers",
                keyColumn: "Id",
                keyValue: new Guid("6a7de3bb-97f4-4a14-b64f-9fc8a8a8b242"));

            migrationBuilder.DeleteData(
                table: "Readers",
                keyColumn: "Id",
                keyValue: new Guid("77cff022-1465-49ac-820c-aa5c1ea1b19e"));

            migrationBuilder.DeleteData(
                table: "Readers",
                keyColumn: "Id",
                keyValue: new Guid("b757d55d-529d-4cc8-89ae-82036564055e"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("01ac681a-b52e-45cb-8b81-182d1cda3520"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("08c709c9-0d6e-4c5c-9b91-77f039dfdb51"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("18b3eeac-a9e1-4098-a094-d9cf9df885df"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("326b3b91-ecd4-48bd-bddb-3fd788d6ea6a"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("37d737e5-6bc1-40a2-a8c6-b34564d48412"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("4d25c8c0-e068-40c7-b316-6acba16c261d"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("4f15eadc-b2e9-4ac8-b7c5-af8f383105ef"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("512a64d4-2940-4897-b202-cb519ece9f19"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("7921061d-840c-4a56-8b1f-841f7390edc8"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("7cc4c6a6-cbab-4105-a8a6-c100e5c85d67"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("80ef7321-b0a3-4453-b1ba-6e3ecf1b0d0e"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("8710dd3c-1f39-4f82-80ee-b098c7c5b3c1"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("a2d0d869-69bb-4d53-8873-25cad510338b"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("a5856006-2bac-42d3-a60c-cb5f39715a19"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("b6fda587-5512-4ccc-9294-5e52c7390773"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("b7d20548-b9fa-4ffe-9166-5b42308864a1"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("baff91b9-a58d-4e3c-a938-3fd293b432ed"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("bcecb84c-9f01-4325-b721-9326fb96f2d7"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("c687f724-506d-448b-9511-e686b91f3dda"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("cf5c7384-0cac-448b-bec1-c4f3eb3769f0"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("ff1ead80-59eb-4049-b0f8-a71d3911dbd5"));

            migrationBuilder.AddColumn<string>(
                name: "CoverImagePath",
                table: "BookDefinitions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fa78fc55-4db8-4dac-80ab-61d95afedcd1", "AQAAAAIAAYagAAAAEMx7VebQWX0LbidKwWNUuxcQTk1yTTh/7OiKgSgL7O7taZjV3HVCqYi+TWIxJRdiuQ==", "1fb975c5-9801-411c-aa2a-fab067a2775b" });

            migrationBuilder.InsertData(
                table: "BookDefinitions",
                columns: new[] { "Id", "Author", "CoverImagePath", "Title" },
                values: new object[,]
                {
                    { new Guid("0df3c1e7-c4ce-4345-8690-41ae36cf7e0a"), "Jo Nesbø", null, "Człowiek nietoperz" },
                    { new Guid("13239f82-b6b8-4f9e-92a2-bbeb119d540c"), "Andrzej Ziemiański", null, "Achaja. Tom I" },
                    { new Guid("2b3dc6ab-52cf-47e2-ae78-5f2d7b634d8b"), "J.K. Rowling", null, "Harry Potter i więzień Azkabanu" },
                    { new Guid("39efc106-9448-4621-a850-cf022e3c9800"), "J.K. Rowling, Jack Thorne", null, "Harry Potter i Przeklęte Dziecko" },
                    { new Guid("45af0124-e2e8-4631-8225-70ab85045db9"), "Camilla Läckberg", null, "Kamieniarz" },
                    { new Guid("5812ead1-1684-4857-a7ea-8a9017e76f3f"), "Camilla Läckberg", null, "Księżniczka z lodu" },
                    { new Guid("6123fdf2-43ed-4dca-95af-6572cf137adc"), "Juliusz Słowacki", null, "Balladyna" },
                    { new Guid("642a67c1-9073-4f83-8869-fdcb42469432"), "Christopher Paolini", null, "Dziedzictwo" },
                    { new Guid("820a4761-d345-4180-8334-edbae0414e39"), "Stieg Larsson", null, "Mężczyźni, którzy nienawidzą kobiet" },
                    { new Guid("838be325-4552-4688-87bb-ded0206897b3"), "J.K. Rowling", null, "Harry Potter i Komnata Tajemnic" },
                    { new Guid("885fc2a2-f86f-4938-ac0c-dc0a1c29f77d"), "Camilla Läckberg", null, "Kaznodzieja" },
                    { new Guid("8d80ef04-8fef-464d-bd8d-75cb634da548"), "J.K. Rowling", null, "Harry Potter i Kamień Filozoficzny" },
                    { new Guid("908fd7c3-492a-4e02-a1b3-5d9031154125"), "Kornel Makuszyński", null, "Szatan z siódmej klasy" },
                    { new Guid("93b2eee5-3403-4820-9a2b-9aaaa17031c7"), "George R.R. Martin", null, "Nawałnica mieczy: Stal i śnieg" },
                    { new Guid("9acd9d92-d907-4166-89ff-f0c45a1ede2b"), "Dan Brown", null, "Inferno" },
                    { new Guid("9fd56902-df65-4cc6-abef-f156e3990d1a"), "Andrzej Sapkowski", null, "Narrenturm" },
                    { new Guid("b2cf3ba9-bed0-4c74-ab8b-548b235ad697"), "J.K. Rowling", null, "Harry Potter i Czara Ognia" },
                    { new Guid("b808092a-ac22-4ee7-b32b-06142f7cfe14"), "George R.R. Martin", null, "Starcie królów (edycja ilustrowana)" },
                    { new Guid("c303ff14-c731-4805-bc7d-5994c4a9f482"), "Camilla Läckberg", null, "Niemiecki bękart" },
                    { new Guid("cf6ea3e2-ba5f-416a-9083-36d82b572cdc"), "Cassandra Clare", null, "Miasto upadłych aniołów" },
                    { new Guid("d79401cd-be93-4f87-8682-b9b304bbfc4d"), "Stanisław Wyspiański", null, "Wesele" },
                    { new Guid("d924d2aa-725a-4bf7-81f0-13d54dfbdf9e"), "William Shakespeare", null, "Romeo i Julia" },
                    { new Guid("da32f2b1-0819-410a-ae2c-4cd5319d967d"), "Juliusz Słowacki", null, "Kordian" },
                    { new Guid("e2e7b502-c33c-4808-9a17-4d616462907c"), "Camilla Läckberg", null, "Ofiara losu" },
                    { new Guid("e35d880f-9495-49ab-a858-b0ccf6b9807e"), "J.K. Rowling", null, "Harry Potter i Zakon Feniksa" },
                    { new Guid("f0b2fe62-5b85-4566-95af-6d1415a580db"), "Władysław Stanisław Reymont", null, "Chłopi" },
                    { new Guid("f19357fb-b6a7-40d9-8a9a-ae51ff8fea4a"), "J.K. Rowling", null, "Harry Potter i Książę Półkrwi" },
                    { new Guid("f46eb56b-2d23-4a40-bbd3-ddf986ff3cf8"), "Johann Wolfgang von Goethe", null, "Cierpienia młodego Wertera" },
                    { new Guid("fe7765be-1248-481f-9e3c-abe3d473654f"), "George R.R. Martin", null, "Gra o tron (edycja ilustrowana)" },
                    { new Guid("feb40f05-0013-4643-8b61-0d426934f4dd"), "Veronica Roth", null, "Niezgodna" }
                });

            migrationBuilder.InsertData(
                table: "Readers",
                columns: new[] { "Id", "City", "Code", "Name", "Street" },
                values: new object[,]
                {
                    { new Guid("03a0b57c-1800-495d-a919-d976404e8d09"), "Poznań", "61-311", "Jan Nowak", "Wieżowa 3" },
                    { new Guid("67042542-a213-4742-9c9b-db804743cc38"), "Poznań", "61-111", "Aleksandra Mechrzycka", "Solna 2" },
                    { new Guid("82ad7c8f-46ba-464b-a14a-50308ef8cf2e"), "Poznań", "61-111", "Tomasz Rydz", "Garbary 1" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "BookDefinitionId", "Comment", "Status" },
                values: new object[,]
                {
                    { new Guid("0049a051-60f1-43a8-a4ef-82ac7a146bcb"), new Guid("c303ff14-c731-4805-bc7d-5994c4a9f482"), null, 2 },
                    { new Guid("00d91ed5-64ba-4865-93ff-0948d2e211ab"), new Guid("45af0124-e2e8-4631-8225-70ab85045db9"), null, 0 },
                    { new Guid("05f13fbd-92b8-49e1-84b8-28382638f5e9"), new Guid("45af0124-e2e8-4631-8225-70ab85045db9"), null, 1 },
                    { new Guid("06ddab75-89e6-4e80-865a-e7a325cc0c28"), new Guid("feb40f05-0013-4643-8b61-0d426934f4dd"), null, 1 },
                    { new Guid("074d3914-3e4e-483d-b782-6b9f8be17003"), new Guid("6123fdf2-43ed-4dca-95af-6572cf137adc"), null, 0 },
                    { new Guid("098e8cb2-81bf-4474-9285-1830db848646"), new Guid("9fd56902-df65-4cc6-abef-f156e3990d1a"), null, 0 },
                    { new Guid("0e773f10-b7d5-4148-afea-a6e6f88f280c"), new Guid("d924d2aa-725a-4bf7-81f0-13d54dfbdf9e"), null, 1 },
                    { new Guid("1125fa44-1e7a-4c6e-9e91-32f339e2859e"), new Guid("45af0124-e2e8-4631-8225-70ab85045db9"), null, 2 },
                    { new Guid("14076a54-0d04-4f98-bb61-6b9598077ce9"), new Guid("fe7765be-1248-481f-9e3c-abe3d473654f"), null, 0 },
                    { new Guid("14ab0108-e536-48d6-826e-93862c96e7dd"), new Guid("da32f2b1-0819-410a-ae2c-4cd5319d967d"), null, 1 },
                    { new Guid("15536ece-293f-470a-8b39-3ed351eb40fd"), new Guid("b808092a-ac22-4ee7-b32b-06142f7cfe14"), null, 2 },
                    { new Guid("1b7dc436-2a59-4c06-add6-e928b4d77ced"), new Guid("f46eb56b-2d23-4a40-bbd3-ddf986ff3cf8"), null, 0 },
                    { new Guid("1be3629a-1344-41e2-a783-8edfc6e38073"), new Guid("820a4761-d345-4180-8334-edbae0414e39"), null, 1 },
                    { new Guid("1ecb0799-1e48-4ac7-933d-76ead74a61b3"), new Guid("820a4761-d345-4180-8334-edbae0414e39"), null, 2 },
                    { new Guid("1edfe277-f4c7-4b70-9617-1b9054ad139a"), new Guid("d79401cd-be93-4f87-8682-b9b304bbfc4d"), null, 0 },
                    { new Guid("22004c82-eeb6-45a2-942f-340932b7b820"), new Guid("93b2eee5-3403-4820-9a2b-9aaaa17031c7"), null, 1 },
                    { new Guid("2402513f-ea23-44b9-8d7b-e65c5f5b95fa"), new Guid("642a67c1-9073-4f83-8869-fdcb42469432"), null, 0 },
                    { new Guid("24cd602c-0094-4f2f-9db5-67acbe311b1a"), new Guid("feb40f05-0013-4643-8b61-0d426934f4dd"), null, 0 },
                    { new Guid("2684edda-5a08-487b-9017-8bab942e1dd4"), new Guid("93b2eee5-3403-4820-9a2b-9aaaa17031c7"), null, 1 },
                    { new Guid("26d02ca4-ee7b-4d96-b6c2-e5cfdb7b1744"), new Guid("cf6ea3e2-ba5f-416a-9083-36d82b572cdc"), null, 1 },
                    { new Guid("29677af5-c8d4-45a0-be63-659d65f02af4"), new Guid("b808092a-ac22-4ee7-b32b-06142f7cfe14"), null, 1 },
                    { new Guid("2a4126e7-72fd-4736-9e3e-a2f88198e8a0"), new Guid("5812ead1-1684-4857-a7ea-8a9017e76f3f"), null, 1 },
                    { new Guid("2ae3cd5e-f67c-4a28-9be2-2e13d089d79c"), new Guid("cf6ea3e2-ba5f-416a-9083-36d82b572cdc"), null, 2 },
                    { new Guid("2dbe9562-02b9-4510-9239-fc99a12c4dd0"), new Guid("2b3dc6ab-52cf-47e2-ae78-5f2d7b634d8b"), null, 2 },
                    { new Guid("2f1ac06a-21d1-49e4-a380-3dcba9375463"), new Guid("9fd56902-df65-4cc6-abef-f156e3990d1a"), null, 2 },
                    { new Guid("301dce68-b28b-474a-88df-3e3891a6a113"), new Guid("13239f82-b6b8-4f9e-92a2-bbeb119d540c"), null, 2 },
                    { new Guid("355d35ce-c799-4678-81ed-108bd8aeef27"), new Guid("6123fdf2-43ed-4dca-95af-6572cf137adc"), null, 0 },
                    { new Guid("3b0bc763-872d-461d-bca6-58e36a3e0052"), new Guid("45af0124-e2e8-4631-8225-70ab85045db9"), null, 2 },
                    { new Guid("3ba9d149-316d-443d-aeab-725c35778189"), new Guid("0df3c1e7-c4ce-4345-8690-41ae36cf7e0a"), null, 2 },
                    { new Guid("3c8a7af3-a5ea-4cbd-8983-67fc16f42b1b"), new Guid("b808092a-ac22-4ee7-b32b-06142f7cfe14"), null, 2 },
                    { new Guid("3d5204db-0cc3-428e-97c2-cf8fb0bdca23"), new Guid("fe7765be-1248-481f-9e3c-abe3d473654f"), null, 2 },
                    { new Guid("403c7988-f600-4670-83c7-09685c2ba7d7"), new Guid("b808092a-ac22-4ee7-b32b-06142f7cfe14"), null, 2 },
                    { new Guid("4177285c-d51f-4f68-99dc-55b64646937a"), new Guid("642a67c1-9073-4f83-8869-fdcb42469432"), null, 1 },
                    { new Guid("49856046-c941-44ac-b340-0b0253dcc750"), new Guid("820a4761-d345-4180-8334-edbae0414e39"), null, 0 },
                    { new Guid("4a6062e6-b7cb-4572-95d7-d8d5e3faac42"), new Guid("93b2eee5-3403-4820-9a2b-9aaaa17031c7"), null, 0 },
                    { new Guid("4d6b2792-6a70-4244-952c-db239000386d"), new Guid("fe7765be-1248-481f-9e3c-abe3d473654f"), null, 1 },
                    { new Guid("4e70194e-5eef-4054-8160-553b33926f4d"), new Guid("908fd7c3-492a-4e02-a1b3-5d9031154125"), null, 2 },
                    { new Guid("506d8072-015b-4371-b4a2-c0d9c2494b52"), new Guid("f0b2fe62-5b85-4566-95af-6d1415a580db"), null, 2 },
                    { new Guid("52e0b8f1-522a-45ab-9be8-1698d29d3edb"), new Guid("d79401cd-be93-4f87-8682-b9b304bbfc4d"), null, 1 },
                    { new Guid("5457f1b9-19ca-4677-a39b-6fcd57a50ea7"), new Guid("9acd9d92-d907-4166-89ff-f0c45a1ede2b"), null, 0 },
                    { new Guid("5f09d389-3aa6-40d6-b8db-fde4db8b13d4"), new Guid("f19357fb-b6a7-40d9-8a9a-ae51ff8fea4a"), null, 0 },
                    { new Guid("61073354-c5f6-4934-9301-6677399dfd9d"), new Guid("908fd7c3-492a-4e02-a1b3-5d9031154125"), null, 2 },
                    { new Guid("623b409c-d75a-40dd-81af-d685bf6ae8f9"), new Guid("908fd7c3-492a-4e02-a1b3-5d9031154125"), null, 1 },
                    { new Guid("636e48fa-c7fe-49c6-af8b-edb0ea598e97"), new Guid("0df3c1e7-c4ce-4345-8690-41ae36cf7e0a"), null, 1 },
                    { new Guid("6438d80e-3644-4ac3-9eee-679923a95dac"), new Guid("c303ff14-c731-4805-bc7d-5994c4a9f482"), null, 1 },
                    { new Guid("65198ea0-1d55-4f64-902e-b9c78913a6eb"), new Guid("cf6ea3e2-ba5f-416a-9083-36d82b572cdc"), null, 1 },
                    { new Guid("67bb532a-dedf-482a-b415-c19fea4b0ddf"), new Guid("d79401cd-be93-4f87-8682-b9b304bbfc4d"), null, 2 },
                    { new Guid("6a9f1db5-83bb-435d-91dc-9dc12af32537"), new Guid("e2e7b502-c33c-4808-9a17-4d616462907c"), null, 2 },
                    { new Guid("6bb3b92f-15a0-41b8-b545-84e722c20504"), new Guid("885fc2a2-f86f-4938-ac0c-dc0a1c29f77d"), null, 1 },
                    { new Guid("6da776df-867d-4591-abec-7ba7cc000b5e"), new Guid("8d80ef04-8fef-464d-bd8d-75cb634da548"), null, 2 },
                    { new Guid("714fa380-ca32-4d56-803e-4b34697ee09a"), new Guid("b808092a-ac22-4ee7-b32b-06142f7cfe14"), null, 0 },
                    { new Guid("720ff325-0167-4fc4-a762-5f2fb6971b46"), new Guid("0df3c1e7-c4ce-4345-8690-41ae36cf7e0a"), null, 0 },
                    { new Guid("744b27a9-dae9-49d2-9368-96b22aa5f802"), new Guid("39efc106-9448-4621-a850-cf022e3c9800"), null, 1 },
                    { new Guid("7767c2f1-2d2d-49f8-ad46-559fc9ffdefd"), new Guid("e2e7b502-c33c-4808-9a17-4d616462907c"), null, 0 },
                    { new Guid("79af1b48-a96d-43e8-b4ee-012395c28d0a"), new Guid("93b2eee5-3403-4820-9a2b-9aaaa17031c7"), null, 1 },
                    { new Guid("7b8dcca4-3cf9-4e14-b300-21dea4275db5"), new Guid("642a67c1-9073-4f83-8869-fdcb42469432"), null, 1 },
                    { new Guid("7cdcfa89-34bc-4f6e-bc23-bbee81df06a6"), new Guid("39efc106-9448-4621-a850-cf022e3c9800"), null, 1 },
                    { new Guid("7fe03ffb-8dd6-42e4-bd1f-31ae9837ad01"), new Guid("c303ff14-c731-4805-bc7d-5994c4a9f482"), null, 2 },
                    { new Guid("803b7f8d-ba29-4756-927f-98dd422131d4"), new Guid("908fd7c3-492a-4e02-a1b3-5d9031154125"), null, 0 },
                    { new Guid("83173125-8435-4ea6-bc44-5767c0007dac"), new Guid("908fd7c3-492a-4e02-a1b3-5d9031154125"), null, 0 },
                    { new Guid("84493936-d22b-4d65-8084-b9ef7c080cbd"), new Guid("feb40f05-0013-4643-8b61-0d426934f4dd"), null, 2 },
                    { new Guid("85fa9a0d-e5e6-4fa0-bf49-2fa69d425b90"), new Guid("cf6ea3e2-ba5f-416a-9083-36d82b572cdc"), null, 0 },
                    { new Guid("8bbed1b4-4ffd-4cc5-addd-0c7e04b2fc64"), new Guid("9fd56902-df65-4cc6-abef-f156e3990d1a"), null, 1 },
                    { new Guid("8da75a61-80a1-4fdd-a20d-b292717783e0"), new Guid("b2cf3ba9-bed0-4c74-ab8b-548b235ad697"), null, 0 },
                    { new Guid("8f6d2a8e-0c1b-4f22-b1d4-1064ddfddf02"), new Guid("fe7765be-1248-481f-9e3c-abe3d473654f"), null, 2 },
                    { new Guid("908089c2-a26b-46a8-bc09-c604aacdd1f1"), new Guid("cf6ea3e2-ba5f-416a-9083-36d82b572cdc"), null, 0 },
                    { new Guid("91bffb8e-4f98-436f-af27-4bc1b3fc1b7a"), new Guid("39efc106-9448-4621-a850-cf022e3c9800"), null, 0 },
                    { new Guid("94ba38cc-a7ac-41e2-a370-8e97720081af"), new Guid("f19357fb-b6a7-40d9-8a9a-ae51ff8fea4a"), null, 0 },
                    { new Guid("982aace9-e929-445d-b653-07c3a48a2c2c"), new Guid("8d80ef04-8fef-464d-bd8d-75cb634da548"), null, 2 },
                    { new Guid("99497dcf-5593-44bf-8e28-7cadfe9f463c"), new Guid("e35d880f-9495-49ab-a858-b0ccf6b9807e"), null, 2 },
                    { new Guid("99dffb41-1620-46d8-bd15-b60789a5ae56"), new Guid("642a67c1-9073-4f83-8869-fdcb42469432"), null, 2 },
                    { new Guid("99ef5a3e-4089-4b52-b2b3-06d4fea20032"), new Guid("d79401cd-be93-4f87-8682-b9b304bbfc4d"), null, 1 },
                    { new Guid("a2d34afa-6e84-4765-9b01-c4cded234493"), new Guid("b808092a-ac22-4ee7-b32b-06142f7cfe14"), null, 0 },
                    { new Guid("a42530ba-7329-4014-8823-3fcb35246108"), new Guid("e2e7b502-c33c-4808-9a17-4d616462907c"), null, 0 },
                    { new Guid("a5c45bb4-3415-4e60-8f80-1a5da185623e"), new Guid("885fc2a2-f86f-4938-ac0c-dc0a1c29f77d"), null, 0 },
                    { new Guid("a8405171-85e3-4469-9624-4717779bc3b6"), new Guid("39efc106-9448-4621-a850-cf022e3c9800"), null, 2 },
                    { new Guid("b13cf88a-a6f5-4e4b-990b-c2d07b5c1486"), new Guid("f46eb56b-2d23-4a40-bbd3-ddf986ff3cf8"), null, 2 },
                    { new Guid("b4ba4cb4-e812-493d-b55a-7295eb299d44"), new Guid("5812ead1-1684-4857-a7ea-8a9017e76f3f"), null, 2 },
                    { new Guid("b81398b3-1422-4184-86eb-e16ba04bf905"), new Guid("9acd9d92-d907-4166-89ff-f0c45a1ede2b"), null, 2 },
                    { new Guid("ba7dbb6e-de55-40e3-ba6c-2bdebead2ea4"), new Guid("c303ff14-c731-4805-bc7d-5994c4a9f482"), null, 0 },
                    { new Guid("bc0c98fb-952e-4350-9d62-3c1af64523bb"), new Guid("5812ead1-1684-4857-a7ea-8a9017e76f3f"), null, 2 },
                    { new Guid("c3d6c5cd-9423-483e-afc2-984c87a8e0ff"), new Guid("d924d2aa-725a-4bf7-81f0-13d54dfbdf9e"), null, 2 },
                    { new Guid("c6048f65-b26f-44bd-98b4-7d72b7844c7f"), new Guid("e35d880f-9495-49ab-a858-b0ccf6b9807e"), null, 1 },
                    { new Guid("ca18d74c-e88c-4b47-9e6e-89b385f6d18b"), new Guid("f0b2fe62-5b85-4566-95af-6d1415a580db"), null, 2 },
                    { new Guid("cf8b46fc-9b70-45cd-b185-a102b80c5f56"), new Guid("838be325-4552-4688-87bb-ded0206897b3"), null, 0 },
                    { new Guid("d07c7567-ecdb-4bb7-897d-e3659468ac3a"), new Guid("d924d2aa-725a-4bf7-81f0-13d54dfbdf9e"), null, 2 },
                    { new Guid("d29f7d05-bcfe-4204-ba0d-bb83915f25a0"), new Guid("13239f82-b6b8-4f9e-92a2-bbeb119d540c"), null, 0 },
                    { new Guid("d34e4d31-985c-4b75-8b8b-5203ce943966"), new Guid("da32f2b1-0819-410a-ae2c-4cd5319d967d"), null, 2 },
                    { new Guid("d8f5d9c9-fdc0-4d57-8fea-118a6bb50b40"), new Guid("b2cf3ba9-bed0-4c74-ab8b-548b235ad697"), null, 0 },
                    { new Guid("d92b31d7-f342-476f-ae86-18d5d1c01d9a"), new Guid("9acd9d92-d907-4166-89ff-f0c45a1ede2b"), null, 1 },
                    { new Guid("df60e7fa-78b0-458a-9e96-e365a780020a"), new Guid("820a4761-d345-4180-8334-edbae0414e39"), null, 1 },
                    { new Guid("e2a983eb-9209-4eda-82d6-0bd6274d61b6"), new Guid("0df3c1e7-c4ce-4345-8690-41ae36cf7e0a"), null, 0 },
                    { new Guid("e6732f8b-6422-45f0-b2b1-e70e622ba398"), new Guid("885fc2a2-f86f-4938-ac0c-dc0a1c29f77d"), null, 1 },
                    { new Guid("e6ecd28b-36e2-4f5d-a709-99482a13336c"), new Guid("2b3dc6ab-52cf-47e2-ae78-5f2d7b634d8b"), null, 2 },
                    { new Guid("ef2f7850-d43b-4e95-b46c-bbba412f9a01"), new Guid("fe7765be-1248-481f-9e3c-abe3d473654f"), null, 2 },
                    { new Guid("f3fab592-2573-494d-8d38-b6b8dc411d46"), new Guid("820a4761-d345-4180-8334-edbae0414e39"), null, 2 },
                    { new Guid("f45e8ca0-62a0-4d88-9b53-c5788f07390d"), new Guid("45af0124-e2e8-4631-8225-70ab85045db9"), null, 1 },
                    { new Guid("f5ca2dc5-f0ba-47b6-81b1-8ea80b7bd72d"), new Guid("c303ff14-c731-4805-bc7d-5994c4a9f482"), null, 1 },
                    { new Guid("f83d35ef-1d9d-443c-b338-db2cc6b96b2f"), new Guid("838be325-4552-4688-87bb-ded0206897b3"), null, 1 },
                    { new Guid("fc2156a7-fd12-4b3d-8255-dbc389115a75"), new Guid("e35d880f-9495-49ab-a858-b0ccf6b9807e"), null, 2 }
                });

            migrationBuilder.InsertData(
                table: "Borrowings",
                columns: new[] { "Id", "BookId", "BorrowDate", "ReaderId", "ReturnDate" },
                values: new object[,]
                {
                    { new Guid("02a3841f-68a3-4ab9-a22e-57811e2df30d"), new Guid("f83d35ef-1d9d-443c-b338-db2cc6b96b2f"), new DateTime(2025, 4, 26, 0, 0, 0, 0, DateTimeKind.Local), new Guid("67042542-a213-4742-9c9b-db804743cc38"), new DateTime(2025, 6, 25, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("08383dc8-d7da-4791-ac57-30320e5b12f8"), new Guid("f5ca2dc5-f0ba-47b6-81b1-8ea80b7bd72d"), new DateTime(2025, 4, 23, 0, 0, 0, 0, DateTimeKind.Local), new Guid("67042542-a213-4742-9c9b-db804743cc38"), new DateTime(2025, 6, 22, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("1082acb4-00f0-4afc-8426-ca27777e37e7"), new Guid("df60e7fa-78b0-458a-9e96-e365a780020a"), new DateTime(2025, 4, 28, 0, 0, 0, 0, DateTimeKind.Local), new Guid("5d31a024-4e84-4f5e-b86b-04b10d79559e"), new DateTime(2025, 6, 27, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("12b70319-507e-4315-8558-6f8d2bebda2c"), new Guid("0e773f10-b7d5-4148-afea-a6e6f88f280c"), new DateTime(2025, 4, 29, 0, 0, 0, 0, DateTimeKind.Local), new Guid("82ad7c8f-46ba-464b-a14a-50308ef8cf2e"), new DateTime(2025, 6, 28, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("15907363-2fba-4e86-a82f-a1421c3f7b9f"), new Guid("52e0b8f1-522a-45ab-9be8-1698d29d3edb"), new DateTime(2025, 4, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("03a0b57c-1800-495d-a919-d976404e8d09"), new DateTime(2025, 6, 18, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("1b32336f-bebc-4f9d-97f5-78bafe95ca41"), new Guid("636e48fa-c7fe-49c6-af8b-edb0ea598e97"), new DateTime(2025, 5, 2, 0, 0, 0, 0, DateTimeKind.Local), new Guid("03a0b57c-1800-495d-a919-d976404e8d09"), new DateTime(2025, 7, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("29cf8c91-32a9-4d88-9795-029fc70d7aae"), new Guid("4177285c-d51f-4f68-99dc-55b64646937a"), new DateTime(2025, 4, 20, 0, 0, 0, 0, DateTimeKind.Local), new Guid("5d31a024-4e84-4f5e-b86b-04b10d79559e"), new DateTime(2025, 6, 19, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("2d6c4a9d-2a73-44d6-8973-d5fecbe42ead"), new Guid("29677af5-c8d4-45a0-be63-659d65f02af4"), new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Local), new Guid("82ad7c8f-46ba-464b-a14a-50308ef8cf2e"), new DateTime(2025, 6, 30, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("336150b9-aff6-482c-ade4-5570c8907340"), new Guid("e6732f8b-6422-45f0-b2b1-e70e622ba398"), new DateTime(2025, 4, 28, 0, 0, 0, 0, DateTimeKind.Local), new Guid("03a0b57c-1800-495d-a919-d976404e8d09"), new DateTime(2025, 6, 27, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("3709308c-2901-4e08-a85e-a29eb64effe4"), new Guid("f45e8ca0-62a0-4d88-9b53-c5788f07390d"), new DateTime(2025, 4, 20, 0, 0, 0, 0, DateTimeKind.Local), new Guid("03a0b57c-1800-495d-a919-d976404e8d09"), new DateTime(2025, 6, 19, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("4d9fcd32-0186-4230-b8ac-f3a13f74e4a9"), new Guid("05f13fbd-92b8-49e1-84b8-28382638f5e9"), new DateTime(2025, 4, 28, 0, 0, 0, 0, DateTimeKind.Local), new Guid("03a0b57c-1800-495d-a919-d976404e8d09"), new DateTime(2025, 6, 27, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("52edfca7-6aa5-4b8a-b920-0013bacd6dff"), new Guid("26d02ca4-ee7b-4d96-b6c2-e5cfdb7b1744"), new DateTime(2025, 4, 18, 0, 0, 0, 0, DateTimeKind.Local), new Guid("03a0b57c-1800-495d-a919-d976404e8d09"), new DateTime(2025, 6, 17, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("62047f3f-bbd7-4111-9e6c-dd34739ebcf6"), new Guid("744b27a9-dae9-49d2-9368-96b22aa5f802"), new DateTime(2025, 4, 22, 0, 0, 0, 0, DateTimeKind.Local), new Guid("5d31a024-4e84-4f5e-b86b-04b10d79559e"), new DateTime(2025, 6, 21, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("70a7a38f-e09a-496a-b511-497c9814592c"), new Guid("2a4126e7-72fd-4736-9e3e-a2f88198e8a0"), new DateTime(2025, 4, 25, 0, 0, 0, 0, DateTimeKind.Local), new Guid("03a0b57c-1800-495d-a919-d976404e8d09"), new DateTime(2025, 6, 24, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("73522fa7-ebdf-485d-9be6-801d5e10f3a9"), new Guid("7cdcfa89-34bc-4f6e-bc23-bbee81df06a6"), new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Local), new Guid("5d31a024-4e84-4f5e-b86b-04b10d79559e"), new DateTime(2025, 6, 30, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("7ca7b7d1-2647-4fe7-9112-b8bd70136509"), new Guid("06ddab75-89e6-4e80-865a-e7a325cc0c28"), new DateTime(2025, 4, 29, 0, 0, 0, 0, DateTimeKind.Local), new Guid("67042542-a213-4742-9c9b-db804743cc38"), new DateTime(2025, 6, 28, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("7ce869cd-8e29-4043-b803-182fae0b3929"), new Guid("4d6b2792-6a70-4244-952c-db239000386d"), new DateTime(2025, 4, 24, 0, 0, 0, 0, DateTimeKind.Local), new Guid("03a0b57c-1800-495d-a919-d976404e8d09"), new DateTime(2025, 6, 23, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("94124834-097b-4b93-a63a-d335899b1088"), new Guid("d92b31d7-f342-476f-ae86-18d5d1c01d9a"), new DateTime(2025, 4, 18, 0, 0, 0, 0, DateTimeKind.Local), new Guid("5d31a024-4e84-4f5e-b86b-04b10d79559e"), new DateTime(2025, 6, 17, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("94279243-dc39-4c19-975a-bc12b049f36d"), new Guid("22004c82-eeb6-45a2-942f-340932b7b820"), new DateTime(2025, 4, 29, 0, 0, 0, 0, DateTimeKind.Local), new Guid("67042542-a213-4742-9c9b-db804743cc38"), new DateTime(2025, 6, 28, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("ae5e53d1-bcfd-43f8-9e24-cdb592c85d2e"), new Guid("14ab0108-e536-48d6-826e-93862c96e7dd"), new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Local), new Guid("67042542-a213-4742-9c9b-db804743cc38"), new DateTime(2025, 6, 30, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("afb8bce5-9c64-43fc-a605-ad9ce71252cb"), new Guid("1be3629a-1344-41e2-a783-8edfc6e38073"), new DateTime(2025, 4, 30, 0, 0, 0, 0, DateTimeKind.Local), new Guid("5d31a024-4e84-4f5e-b86b-04b10d79559e"), new DateTime(2025, 6, 29, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("b4a8a38e-3938-4599-963d-421400e27c28"), new Guid("65198ea0-1d55-4f64-902e-b9c78913a6eb"), new DateTime(2025, 4, 24, 0, 0, 0, 0, DateTimeKind.Local), new Guid("82ad7c8f-46ba-464b-a14a-50308ef8cf2e"), new DateTime(2025, 6, 23, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("b6192810-3b36-4a1c-9e4d-4fe751b8842f"), new Guid("7b8dcca4-3cf9-4e14-b300-21dea4275db5"), new DateTime(2025, 4, 25, 0, 0, 0, 0, DateTimeKind.Local), new Guid("82ad7c8f-46ba-464b-a14a-50308ef8cf2e"), new DateTime(2025, 6, 24, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("b8011a05-e935-4638-8e47-372fc7925fad"), new Guid("6bb3b92f-15a0-41b8-b545-84e722c20504"), new DateTime(2025, 5, 2, 0, 0, 0, 0, DateTimeKind.Local), new Guid("67042542-a213-4742-9c9b-db804743cc38"), new DateTime(2025, 7, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("bdad6b55-5621-4f4a-92fc-d0abb1b19a6f"), new Guid("79af1b48-a96d-43e8-b4ee-012395c28d0a"), new DateTime(2025, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), new Guid("03a0b57c-1800-495d-a919-d976404e8d09"), new DateTime(2025, 6, 26, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("c5413300-d895-4f06-9055-a6b460d43edd"), new Guid("2684edda-5a08-487b-9017-8bab942e1dd4"), new DateTime(2025, 4, 22, 0, 0, 0, 0, DateTimeKind.Local), new Guid("5d31a024-4e84-4f5e-b86b-04b10d79559e"), new DateTime(2025, 6, 21, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("d079f4e8-a67a-4dd1-ba20-3cf49511b1c3"), new Guid("c6048f65-b26f-44bd-98b4-7d72b7844c7f"), new DateTime(2025, 4, 20, 0, 0, 0, 0, DateTimeKind.Local), new Guid("5d31a024-4e84-4f5e-b86b-04b10d79559e"), new DateTime(2025, 6, 19, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("dac52c15-d6ea-4463-b1d0-59713441df45"), new Guid("623b409c-d75a-40dd-81af-d685bf6ae8f9"), new DateTime(2025, 4, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("5d31a024-4e84-4f5e-b86b-04b10d79559e"), new DateTime(2025, 6, 18, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("f5fb4372-472d-40c9-bba9-4e7b6bc3af1a"), new Guid("99ef5a3e-4089-4b52-b2b3-06d4fea20032"), new DateTime(2025, 5, 2, 0, 0, 0, 0, DateTimeKind.Local), new Guid("03a0b57c-1800-495d-a919-d976404e8d09"), new DateTime(2025, 7, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("f66b4ceb-68f1-4f6a-b428-e082f2c386df"), new Guid("6438d80e-3644-4ac3-9eee-679923a95dac"), new DateTime(2025, 4, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("5d31a024-4e84-4f5e-b86b-04b10d79559e"), new DateTime(2025, 6, 18, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("fe4e2eea-4412-4725-94f9-d6d5fbb9dc75"), new Guid("8bbed1b4-4ffd-4cc5-addd-0c7e04b2fc64"), new DateTime(2025, 4, 25, 0, 0, 0, 0, DateTimeKind.Local), new Guid("67042542-a213-4742-9c9b-db804743cc38"), new DateTime(2025, 6, 24, 0, 0, 0, 0, DateTimeKind.Local) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0049a051-60f1-43a8-a4ef-82ac7a146bcb"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("00d91ed5-64ba-4865-93ff-0948d2e211ab"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("074d3914-3e4e-483d-b782-6b9f8be17003"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("098e8cb2-81bf-4474-9285-1830db848646"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1125fa44-1e7a-4c6e-9e91-32f339e2859e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("14076a54-0d04-4f98-bb61-6b9598077ce9"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("15536ece-293f-470a-8b39-3ed351eb40fd"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1b7dc436-2a59-4c06-add6-e928b4d77ced"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1ecb0799-1e48-4ac7-933d-76ead74a61b3"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1edfe277-f4c7-4b70-9617-1b9054ad139a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2402513f-ea23-44b9-8d7b-e65c5f5b95fa"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("24cd602c-0094-4f2f-9db5-67acbe311b1a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2ae3cd5e-f67c-4a28-9be2-2e13d089d79c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2dbe9562-02b9-4510-9239-fc99a12c4dd0"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2f1ac06a-21d1-49e4-a380-3dcba9375463"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("301dce68-b28b-474a-88df-3e3891a6a113"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("355d35ce-c799-4678-81ed-108bd8aeef27"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("3b0bc763-872d-461d-bca6-58e36a3e0052"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("3ba9d149-316d-443d-aeab-725c35778189"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("3c8a7af3-a5ea-4cbd-8983-67fc16f42b1b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("3d5204db-0cc3-428e-97c2-cf8fb0bdca23"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("403c7988-f600-4670-83c7-09685c2ba7d7"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("49856046-c941-44ac-b340-0b0253dcc750"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4a6062e6-b7cb-4572-95d7-d8d5e3faac42"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4e70194e-5eef-4054-8160-553b33926f4d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("506d8072-015b-4371-b4a2-c0d9c2494b52"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("5457f1b9-19ca-4677-a39b-6fcd57a50ea7"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("5f09d389-3aa6-40d6-b8db-fde4db8b13d4"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("61073354-c5f6-4934-9301-6677399dfd9d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("67bb532a-dedf-482a-b415-c19fea4b0ddf"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("6a9f1db5-83bb-435d-91dc-9dc12af32537"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("6da776df-867d-4591-abec-7ba7cc000b5e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("714fa380-ca32-4d56-803e-4b34697ee09a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("720ff325-0167-4fc4-a762-5f2fb6971b46"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("7767c2f1-2d2d-49f8-ad46-559fc9ffdefd"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("7fe03ffb-8dd6-42e4-bd1f-31ae9837ad01"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("803b7f8d-ba29-4756-927f-98dd422131d4"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("83173125-8435-4ea6-bc44-5767c0007dac"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("84493936-d22b-4d65-8084-b9ef7c080cbd"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("85fa9a0d-e5e6-4fa0-bf49-2fa69d425b90"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8da75a61-80a1-4fdd-a20d-b292717783e0"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8f6d2a8e-0c1b-4f22-b1d4-1064ddfddf02"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("908089c2-a26b-46a8-bc09-c604aacdd1f1"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("91bffb8e-4f98-436f-af27-4bc1b3fc1b7a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("94ba38cc-a7ac-41e2-a370-8e97720081af"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("982aace9-e929-445d-b653-07c3a48a2c2c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("99497dcf-5593-44bf-8e28-7cadfe9f463c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("99dffb41-1620-46d8-bd15-b60789a5ae56"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a2d34afa-6e84-4765-9b01-c4cded234493"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a42530ba-7329-4014-8823-3fcb35246108"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a5c45bb4-3415-4e60-8f80-1a5da185623e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a8405171-85e3-4469-9624-4717779bc3b6"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b13cf88a-a6f5-4e4b-990b-c2d07b5c1486"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b4ba4cb4-e812-493d-b55a-7295eb299d44"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b81398b3-1422-4184-86eb-e16ba04bf905"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ba7dbb6e-de55-40e3-ba6c-2bdebead2ea4"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("bc0c98fb-952e-4350-9d62-3c1af64523bb"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c3d6c5cd-9423-483e-afc2-984c87a8e0ff"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ca18d74c-e88c-4b47-9e6e-89b385f6d18b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("cf8b46fc-9b70-45cd-b185-a102b80c5f56"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d07c7567-ecdb-4bb7-897d-e3659468ac3a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d29f7d05-bcfe-4204-ba0d-bb83915f25a0"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d34e4d31-985c-4b75-8b8b-5203ce943966"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d8f5d9c9-fdc0-4d57-8fea-118a6bb50b40"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e2a983eb-9209-4eda-82d6-0bd6274d61b6"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e6ecd28b-36e2-4f5d-a709-99482a13336c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ef2f7850-d43b-4e95-b46c-bbba412f9a01"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f3fab592-2573-494d-8d38-b6b8dc411d46"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("fc2156a7-fd12-4b3d-8255-dbc389115a75"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("02a3841f-68a3-4ab9-a22e-57811e2df30d"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("08383dc8-d7da-4791-ac57-30320e5b12f8"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("1082acb4-00f0-4afc-8426-ca27777e37e7"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("12b70319-507e-4315-8558-6f8d2bebda2c"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("15907363-2fba-4e86-a82f-a1421c3f7b9f"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("1b32336f-bebc-4f9d-97f5-78bafe95ca41"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("29cf8c91-32a9-4d88-9795-029fc70d7aae"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("2d6c4a9d-2a73-44d6-8973-d5fecbe42ead"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("336150b9-aff6-482c-ade4-5570c8907340"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("3709308c-2901-4e08-a85e-a29eb64effe4"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("4d9fcd32-0186-4230-b8ac-f3a13f74e4a9"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("52edfca7-6aa5-4b8a-b920-0013bacd6dff"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("62047f3f-bbd7-4111-9e6c-dd34739ebcf6"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("70a7a38f-e09a-496a-b511-497c9814592c"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("73522fa7-ebdf-485d-9be6-801d5e10f3a9"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("7ca7b7d1-2647-4fe7-9112-b8bd70136509"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("7ce869cd-8e29-4043-b803-182fae0b3929"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("94124834-097b-4b93-a63a-d335899b1088"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("94279243-dc39-4c19-975a-bc12b049f36d"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("ae5e53d1-bcfd-43f8-9e24-cdb592c85d2e"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("afb8bce5-9c64-43fc-a605-ad9ce71252cb"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("b4a8a38e-3938-4599-963d-421400e27c28"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("b6192810-3b36-4a1c-9e4d-4fe751b8842f"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("b8011a05-e935-4638-8e47-372fc7925fad"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("bdad6b55-5621-4f4a-92fc-d0abb1b19a6f"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("c5413300-d895-4f06-9055-a6b460d43edd"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("d079f4e8-a67a-4dd1-ba20-3cf49511b1c3"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("dac52c15-d6ea-4463-b1d0-59713441df45"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("f5fb4372-472d-40c9-bba9-4e7b6bc3af1a"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("f66b4ceb-68f1-4f6a-b428-e082f2c386df"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("fe4e2eea-4412-4725-94f9-d6d5fbb9dc75"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("13239f82-b6b8-4f9e-92a2-bbeb119d540c"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("2b3dc6ab-52cf-47e2-ae78-5f2d7b634d8b"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("6123fdf2-43ed-4dca-95af-6572cf137adc"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("8d80ef04-8fef-464d-bd8d-75cb634da548"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("b2cf3ba9-bed0-4c74-ab8b-548b235ad697"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("e2e7b502-c33c-4808-9a17-4d616462907c"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("f0b2fe62-5b85-4566-95af-6d1415a580db"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("f19357fb-b6a7-40d9-8a9a-ae51ff8fea4a"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("f46eb56b-2d23-4a40-bbd3-ddf986ff3cf8"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("05f13fbd-92b8-49e1-84b8-28382638f5e9"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("06ddab75-89e6-4e80-865a-e7a325cc0c28"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0e773f10-b7d5-4148-afea-a6e6f88f280c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("14ab0108-e536-48d6-826e-93862c96e7dd"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1be3629a-1344-41e2-a783-8edfc6e38073"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("22004c82-eeb6-45a2-942f-340932b7b820"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2684edda-5a08-487b-9017-8bab942e1dd4"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("26d02ca4-ee7b-4d96-b6c2-e5cfdb7b1744"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("29677af5-c8d4-45a0-be63-659d65f02af4"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2a4126e7-72fd-4736-9e3e-a2f88198e8a0"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4177285c-d51f-4f68-99dc-55b64646937a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4d6b2792-6a70-4244-952c-db239000386d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("52e0b8f1-522a-45ab-9be8-1698d29d3edb"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("623b409c-d75a-40dd-81af-d685bf6ae8f9"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("636e48fa-c7fe-49c6-af8b-edb0ea598e97"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("6438d80e-3644-4ac3-9eee-679923a95dac"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("65198ea0-1d55-4f64-902e-b9c78913a6eb"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("6bb3b92f-15a0-41b8-b545-84e722c20504"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("744b27a9-dae9-49d2-9368-96b22aa5f802"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("79af1b48-a96d-43e8-b4ee-012395c28d0a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("7b8dcca4-3cf9-4e14-b300-21dea4275db5"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("7cdcfa89-34bc-4f6e-bc23-bbee81df06a6"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8bbed1b4-4ffd-4cc5-addd-0c7e04b2fc64"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("99ef5a3e-4089-4b52-b2b3-06d4fea20032"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c6048f65-b26f-44bd-98b4-7d72b7844c7f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d92b31d7-f342-476f-ae86-18d5d1c01d9a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("df60e7fa-78b0-458a-9e96-e365a780020a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e6732f8b-6422-45f0-b2b1-e70e622ba398"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f45e8ca0-62a0-4d88-9b53-c5788f07390d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f5ca2dc5-f0ba-47b6-81b1-8ea80b7bd72d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f83d35ef-1d9d-443c-b338-db2cc6b96b2f"));

            migrationBuilder.DeleteData(
                table: "Readers",
                keyColumn: "Id",
                keyValue: new Guid("03a0b57c-1800-495d-a919-d976404e8d09"));

            migrationBuilder.DeleteData(
                table: "Readers",
                keyColumn: "Id",
                keyValue: new Guid("67042542-a213-4742-9c9b-db804743cc38"));

            migrationBuilder.DeleteData(
                table: "Readers",
                keyColumn: "Id",
                keyValue: new Guid("82ad7c8f-46ba-464b-a14a-50308ef8cf2e"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("0df3c1e7-c4ce-4345-8690-41ae36cf7e0a"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("39efc106-9448-4621-a850-cf022e3c9800"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("45af0124-e2e8-4631-8225-70ab85045db9"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("5812ead1-1684-4857-a7ea-8a9017e76f3f"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("642a67c1-9073-4f83-8869-fdcb42469432"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("820a4761-d345-4180-8334-edbae0414e39"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("838be325-4552-4688-87bb-ded0206897b3"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("885fc2a2-f86f-4938-ac0c-dc0a1c29f77d"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("908fd7c3-492a-4e02-a1b3-5d9031154125"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("93b2eee5-3403-4820-9a2b-9aaaa17031c7"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("9acd9d92-d907-4166-89ff-f0c45a1ede2b"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("9fd56902-df65-4cc6-abef-f156e3990d1a"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("b808092a-ac22-4ee7-b32b-06142f7cfe14"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("c303ff14-c731-4805-bc7d-5994c4a9f482"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("cf6ea3e2-ba5f-416a-9083-36d82b572cdc"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("d79401cd-be93-4f87-8682-b9b304bbfc4d"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("d924d2aa-725a-4bf7-81f0-13d54dfbdf9e"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("da32f2b1-0819-410a-ae2c-4cd5319d967d"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("e35d880f-9495-49ab-a858-b0ccf6b9807e"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("fe7765be-1248-481f-9e3c-abe3d473654f"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("feb40f05-0013-4643-8b61-0d426934f4dd"));

            migrationBuilder.DropColumn(
                name: "CoverImagePath",
                table: "BookDefinitions");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eb11eff1-7697-474c-979d-f7ae56a0c530", "AQAAAAIAAYagAAAAEILEvMFJX3gvimmB1QeH3Qf8ttQKgNHTXnSqwo9lDHW2QgFsGNfD+KVpQQIQVZ98og==", "5f9c743c-7aaa-4914-a823-0353641e8888" });

            migrationBuilder.InsertData(
                table: "BookDefinitions",
                columns: new[] { "Id", "Author", "Title" },
                values: new object[,]
                {
                    { new Guid("01ac681a-b52e-45cb-8b81-182d1cda3520"), "Camilla Läckberg", "Ofiara losu" },
                    { new Guid("08c709c9-0d6e-4c5c-9b91-77f039dfdb51"), "Juliusz Słowacki", "Balladyna" },
                    { new Guid("0a097611-ce71-4a35-8b70-e3e855a70ae7"), "J.K. Rowling", "Harry Potter i Książę Półkrwi" },
                    { new Guid("0d0f72a9-d358-4283-aca5-15811ed0aeb8"), "J.K. Rowling", "Harry Potter i Zakon Feniksa" },
                    { new Guid("18b3eeac-a9e1-4098-a094-d9cf9df885df"), "J.K. Rowling", "Harry Potter i Czara Ognia" },
                    { new Guid("2ba37673-a6e9-4539-9f68-24921544db84"), "Kornel Makuszyński", "Szatan z siódmej klasy" },
                    { new Guid("2eb18b3a-eb70-4984-b20e-eba3082dd5c3"), "Juliusz Słowacki", "Kordian" },
                    { new Guid("326b3b91-ecd4-48bd-bddb-3fd788d6ea6a"), "Stieg Larsson", "Mężczyźni, którzy nienawidzą kobiet" },
                    { new Guid("37d737e5-6bc1-40a2-a8c6-b34564d48412"), "Andrzej Sapkowski", "Narrenturm" },
                    { new Guid("3e0d0ba3-8d04-4700-91bf-f3e3d78129ef"), "George R.R. Martin", "Gra o tron (edycja ilustrowana)" },
                    { new Guid("4d25c8c0-e068-40c7-b316-6acba16c261d"), "Christopher Paolini", "Dziedzictwo" },
                    { new Guid("4f15eadc-b2e9-4ac8-b7c5-af8f383105ef"), "Władysław Stanisław Reymont", "Chłopi" },
                    { new Guid("512a64d4-2940-4897-b202-cb519ece9f19"), "Andrzej Ziemiański", "Achaja. Tom I" },
                    { new Guid("7132bc9d-aec5-419a-8594-a427b49a0393"), "J.K. Rowling", "Harry Potter i więzień Azkabanu" },
                    { new Guid("7921061d-840c-4a56-8b1f-841f7390edc8"), "Johann Wolfgang von Goethe", "Cierpienia młodego Wertera" },
                    { new Guid("7cc4c6a6-cbab-4105-a8a6-c100e5c85d67"), "Cassandra Clare", "Miasto upadłych aniołów" },
                    { new Guid("80ef7321-b0a3-4453-b1ba-6e3ecf1b0d0e"), "Camilla Läckberg", "Niemiecki bękart" },
                    { new Guid("8710dd3c-1f39-4f82-80ee-b098c7c5b3c1"), "Camilla Läckberg", "Księżniczka z lodu" },
                    { new Guid("8aa0f520-e3aa-4838-b4b8-54b3fda386a3"), "William Shakespeare", "Romeo i Julia" },
                    { new Guid("a2d0d869-69bb-4d53-8873-25cad510338b"), "George R.R. Martin", "Starcie królów (edycja ilustrowana)" },
                    { new Guid("a5856006-2bac-42d3-a60c-cb5f39715a19"), "George R.R. Martin", "Nawałnica mieczy: Stal i śnieg" },
                    { new Guid("b6fda587-5512-4ccc-9294-5e52c7390773"), "Jo Nesbø", "Człowiek nietoperz" },
                    { new Guid("b7d20548-b9fa-4ffe-9166-5b42308864a1"), "J.K. Rowling, Jack Thorne", "Harry Potter i Przeklęte Dziecko" },
                    { new Guid("baff91b9-a58d-4e3c-a938-3fd293b432ed"), "Camilla Läckberg", "Kaznodzieja" },
                    { new Guid("bcecb84c-9f01-4325-b721-9326fb96f2d7"), "Dan Brown", "Inferno" },
                    { new Guid("c687f724-506d-448b-9511-e686b91f3dda"), "Veronica Roth", "Niezgodna" },
                    { new Guid("c72c0bbb-32eb-4676-a628-2b1aea7e434b"), "Stanisław Wyspiański", "Wesele" },
                    { new Guid("cf5c7384-0cac-448b-bec1-c4f3eb3769f0"), "J.K. Rowling", "Harry Potter i Komnata Tajemnic" },
                    { new Guid("e1a08da5-0c3e-4f4c-8f75-3fde7ef6c9b7"), "J.K. Rowling", "Harry Potter i Kamień Filozoficzny" },
                    { new Guid("ff1ead80-59eb-4049-b0f8-a71d3911dbd5"), "Camilla Läckberg", "Kamieniarz" }
                });

            migrationBuilder.InsertData(
                table: "Readers",
                columns: new[] { "Id", "City", "Code", "Name", "Street" },
                values: new object[,]
                {
                    { new Guid("6a7de3bb-97f4-4a14-b64f-9fc8a8a8b242"), "Poznań", "61-111", "Tomasz Rydz", "Garbary 1" },
                    { new Guid("77cff022-1465-49ac-820c-aa5c1ea1b19e"), "Poznań", "61-111", "Aleksandra Mechrzycka", "Solna 2" },
                    { new Guid("b757d55d-529d-4cc8-89ae-82036564055e"), "Poznań", "61-311", "Jan Nowak", "Wieżowa 3" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "BookDefinitionId", "Comment", "Status" },
                values: new object[,]
                {
                    { new Guid("04458325-54c3-4f25-b16e-5e8f0fce2562"), new Guid("a5856006-2bac-42d3-a60c-cb5f39715a19"), null, 2 },
                    { new Guid("079638cb-6d07-4ad6-963f-56cfccee80c7"), new Guid("baff91b9-a58d-4e3c-a938-3fd293b432ed"), null, 1 },
                    { new Guid("1102a15c-bc66-4291-ac12-8069ef385393"), new Guid("8710dd3c-1f39-4f82-80ee-b098c7c5b3c1"), null, 1 },
                    { new Guid("16aa5a85-50e6-4b37-b310-1ca8ffabd155"), new Guid("37d737e5-6bc1-40a2-a8c6-b34564d48412"), null, 1 },
                    { new Guid("19a2c0cf-b56a-4cc6-9d55-cce66a648bd2"), new Guid("4f15eadc-b2e9-4ac8-b7c5-af8f383105ef"), null, 2 },
                    { new Guid("1ca457bb-65a3-4368-87a7-cfb4c60fb149"), new Guid("7921061d-840c-4a56-8b1f-841f7390edc8"), null, 1 },
                    { new Guid("20ec3e8b-8c3b-4dee-9da7-093579c71a4f"), new Guid("7cc4c6a6-cbab-4105-a8a6-c100e5c85d67"), null, 1 },
                    { new Guid("217e2ead-b9de-4a38-a2ab-995f9515a8b7"), new Guid("01ac681a-b52e-45cb-8b81-182d1cda3520"), null, 2 },
                    { new Guid("21c536c4-494c-44f1-84c5-be8fe6145b58"), new Guid("c687f724-506d-448b-9511-e686b91f3dda"), null, 1 },
                    { new Guid("28e868af-842e-43f2-8a45-447f8e14031c"), new Guid("7921061d-840c-4a56-8b1f-841f7390edc8"), null, 1 },
                    { new Guid("29a2798b-2d43-429c-b232-704e0e42a61e"), new Guid("7921061d-840c-4a56-8b1f-841f7390edc8"), null, 2 },
                    { new Guid("2bafac4d-096e-493a-be81-b862350189e7"), new Guid("18b3eeac-a9e1-4098-a094-d9cf9df885df"), null, 0 },
                    { new Guid("30dc1b8c-6f90-48ba-8434-dcd5be4d8276"), new Guid("7132bc9d-aec5-419a-8594-a427b49a0393"), null, 2 },
                    { new Guid("3273742c-d607-4b81-ae55-3d65b3941f9c"), new Guid("cf5c7384-0cac-448b-bec1-c4f3eb3769f0"), null, 2 },
                    { new Guid("3550d8b6-c72e-47a8-bf8c-3982f945105d"), new Guid("01ac681a-b52e-45cb-8b81-182d1cda3520"), null, 1 },
                    { new Guid("3dedc88b-8f8b-403e-9468-e782adfe22ef"), new Guid("326b3b91-ecd4-48bd-bddb-3fd788d6ea6a"), null, 2 },
                    { new Guid("3df99c7e-dc10-420d-ac5c-9547f930c9bc"), new Guid("e1a08da5-0c3e-4f4c-8f75-3fde7ef6c9b7"), null, 2 },
                    { new Guid("428d8f2a-4f09-4f20-bff6-cd9de70e8204"), new Guid("7cc4c6a6-cbab-4105-a8a6-c100e5c85d67"), null, 2 },
                    { new Guid("42aae123-5f81-439c-b85c-86b194f5ac84"), new Guid("a2d0d869-69bb-4d53-8873-25cad510338b"), null, 0 },
                    { new Guid("435579ed-f57d-45d5-bfc2-41aeaa03b0bc"), new Guid("8aa0f520-e3aa-4838-b4b8-54b3fda386a3"), null, 0 },
                    { new Guid("461e28c6-ed59-4055-80a7-a34730a367ba"), new Guid("0d0f72a9-d358-4283-aca5-15811ed0aeb8"), null, 0 },
                    { new Guid("4746d247-4e52-40e2-8d46-e9c97fd9748d"), new Guid("7921061d-840c-4a56-8b1f-841f7390edc8"), null, 1 },
                    { new Guid("4c2cbb8e-f1b7-4bc8-b5b6-0b64a62ae510"), new Guid("bcecb84c-9f01-4325-b721-9326fb96f2d7"), null, 2 },
                    { new Guid("4d2cc9be-bb09-44ed-9f37-0e9ef3466926"), new Guid("bcecb84c-9f01-4325-b721-9326fb96f2d7"), null, 0 },
                    { new Guid("522672d0-5c49-45a0-8533-142c81cfe905"), new Guid("0d0f72a9-d358-4283-aca5-15811ed0aeb8"), null, 0 },
                    { new Guid("52f38433-da32-445e-aeed-769c21c5e6de"), new Guid("4d25c8c0-e068-40c7-b316-6acba16c261d"), null, 1 },
                    { new Guid("53e62ef4-f0fe-419b-8e02-34f920862cbb"), new Guid("b7d20548-b9fa-4ffe-9166-5b42308864a1"), null, 2 },
                    { new Guid("5694a295-f5ea-46ec-bd54-8f625aa4707c"), new Guid("4d25c8c0-e068-40c7-b316-6acba16c261d"), null, 2 },
                    { new Guid("57650987-400b-4a05-9314-472676a3e68f"), new Guid("ff1ead80-59eb-4049-b0f8-a71d3911dbd5"), null, 0 },
                    { new Guid("5d7826ed-31e5-4ae8-93f4-ebd17dd2ff53"), new Guid("0d0f72a9-d358-4283-aca5-15811ed0aeb8"), null, 0 },
                    { new Guid("687f20d1-fcb5-40d4-8261-96469633348a"), new Guid("7cc4c6a6-cbab-4105-a8a6-c100e5c85d67"), null, 0 },
                    { new Guid("68dd801b-29a6-49e0-9615-1116b02d4f29"), new Guid("8aa0f520-e3aa-4838-b4b8-54b3fda386a3"), null, 0 },
                    { new Guid("69a4237b-f0f7-46f3-84c7-08893d583391"), new Guid("b6fda587-5512-4ccc-9294-5e52c7390773"), null, 0 },
                    { new Guid("6c3cc738-65cc-4c63-9cfd-8bdcae010a84"), new Guid("4f15eadc-b2e9-4ac8-b7c5-af8f383105ef"), null, 1 },
                    { new Guid("7006ca97-25b0-4d67-a7a4-b91bc6fc4d16"), new Guid("7cc4c6a6-cbab-4105-a8a6-c100e5c85d67"), null, 1 },
                    { new Guid("706c489e-ba97-47d9-b65b-1c131a39acab"), new Guid("8aa0f520-e3aa-4838-b4b8-54b3fda386a3"), null, 2 },
                    { new Guid("73d4d398-6788-4b58-87ff-dfdc5b977dc9"), new Guid("4f15eadc-b2e9-4ac8-b7c5-af8f383105ef"), null, 2 },
                    { new Guid("740f47fe-fd84-4362-aeee-0466b0361aa9"), new Guid("326b3b91-ecd4-48bd-bddb-3fd788d6ea6a"), null, 0 },
                    { new Guid("7748142b-c549-45af-b7e9-7857acf63d63"), new Guid("80ef7321-b0a3-4453-b1ba-6e3ecf1b0d0e"), null, 0 },
                    { new Guid("77b9510b-5310-4a1f-b5ad-3b310fc432ea"), new Guid("512a64d4-2940-4897-b202-cb519ece9f19"), null, 1 },
                    { new Guid("77d2ebd2-1446-448f-8099-4a45f20f0ffb"), new Guid("80ef7321-b0a3-4453-b1ba-6e3ecf1b0d0e"), null, 0 },
                    { new Guid("78587f17-5dec-4ae4-b4f0-216b0e1866ed"), new Guid("80ef7321-b0a3-4453-b1ba-6e3ecf1b0d0e"), null, 1 },
                    { new Guid("7a0a4ec2-dad5-41e5-9702-0b942b0043dd"), new Guid("a2d0d869-69bb-4d53-8873-25cad510338b"), null, 0 },
                    { new Guid("7d977b68-ea78-4217-b6a4-a16afdc6b18c"), new Guid("326b3b91-ecd4-48bd-bddb-3fd788d6ea6a"), null, 1 },
                    { new Guid("80c3cac4-9b75-431f-93dd-12b3e480281d"), new Guid("bcecb84c-9f01-4325-b721-9326fb96f2d7"), null, 1 },
                    { new Guid("812d4f76-5d7e-4801-bb46-826f0521fa65"), new Guid("08c709c9-0d6e-4c5c-9b91-77f039dfdb51"), null, 0 },
                    { new Guid("818d1105-03f3-4ea0-adcd-516f3f413842"), new Guid("e1a08da5-0c3e-4f4c-8f75-3fde7ef6c9b7"), null, 2 },
                    { new Guid("85c515c7-3ae7-4845-b5ab-043eb413bd22"), new Guid("ff1ead80-59eb-4049-b0f8-a71d3911dbd5"), null, 1 },
                    { new Guid("8600bd80-5d2f-4a26-93c9-8ad950b4f87e"), new Guid("08c709c9-0d6e-4c5c-9b91-77f039dfdb51"), null, 1 },
                    { new Guid("86a88a4e-d4aa-44c7-9a56-e0253efc60fc"), new Guid("a5856006-2bac-42d3-a60c-cb5f39715a19"), null, 1 },
                    { new Guid("872ff021-0db3-4d31-be94-58d48b8be986"), new Guid("08c709c9-0d6e-4c5c-9b91-77f039dfdb51"), null, 2 },
                    { new Guid("874c32cd-7e95-479e-b709-c044b3a43896"), new Guid("0a097611-ce71-4a35-8b70-e3e855a70ae7"), null, 0 },
                    { new Guid("8e956fed-01da-421c-8ea4-790d0c14bffa"), new Guid("b6fda587-5512-4ccc-9294-5e52c7390773"), null, 2 },
                    { new Guid("97fd701a-3ea5-4420-be7d-0f0d00f31958"), new Guid("c687f724-506d-448b-9511-e686b91f3dda"), null, 0 },
                    { new Guid("98ddb6e6-db0b-4066-8ac6-d84b0453856a"), new Guid("0a097611-ce71-4a35-8b70-e3e855a70ae7"), null, 0 },
                    { new Guid("9a42a451-c4a1-4a6c-934a-3ad5315b0bc8"), new Guid("4d25c8c0-e068-40c7-b316-6acba16c261d"), null, 2 },
                    { new Guid("9aa721a3-8746-43c9-b1eb-6476d2dacacc"), new Guid("37d737e5-6bc1-40a2-a8c6-b34564d48412"), null, 1 },
                    { new Guid("9b61bcd3-8c89-4c6e-bbd6-f983861c0a98"), new Guid("7132bc9d-aec5-419a-8594-a427b49a0393"), null, 0 },
                    { new Guid("9cdcb892-7152-4032-a402-a9ba267b3b02"), new Guid("a2d0d869-69bb-4d53-8873-25cad510338b"), null, 2 },
                    { new Guid("a26434dd-0bce-44c6-b47d-7fa81425e9a6"), new Guid("512a64d4-2940-4897-b202-cb519ece9f19"), null, 2 },
                    { new Guid("a404267e-8bbf-4d7c-a099-35583479fefa"), new Guid("b7d20548-b9fa-4ffe-9166-5b42308864a1"), null, 2 },
                    { new Guid("a4263179-198f-471a-b7f5-747e2aa05c50"), new Guid("01ac681a-b52e-45cb-8b81-182d1cda3520"), null, 1 },
                    { new Guid("a77ab981-9426-40c4-8289-735bdca7ef3f"), new Guid("b6fda587-5512-4ccc-9294-5e52c7390773"), null, 1 },
                    { new Guid("a908b462-f860-42eb-aba6-f1cbbaab0989"), new Guid("326b3b91-ecd4-48bd-bddb-3fd788d6ea6a"), null, 1 },
                    { new Guid("a9ef1d77-4272-49b4-aa5b-77a0b0dbee80"), new Guid("e1a08da5-0c3e-4f4c-8f75-3fde7ef6c9b7"), null, 2 },
                    { new Guid("ab9d7520-8bdc-4e8a-8e1c-597d8678b846"), new Guid("e1a08da5-0c3e-4f4c-8f75-3fde7ef6c9b7"), null, 0 },
                    { new Guid("b0572f4e-2e8d-41d8-8bb1-3711f72a58a8"), new Guid("80ef7321-b0a3-4453-b1ba-6e3ecf1b0d0e"), null, 2 },
                    { new Guid("b0c59b6f-3213-4ce4-adc6-f8450208d0ab"), new Guid("2ba37673-a6e9-4539-9f68-24921544db84"), null, 0 },
                    { new Guid("b2d99989-50e6-4a17-a9ae-a7480e127f53"), new Guid("37d737e5-6bc1-40a2-a8c6-b34564d48412"), null, 2 },
                    { new Guid("b64e0711-4ac0-4cf9-aa4d-9e5d2e6167ac"), new Guid("8710dd3c-1f39-4f82-80ee-b098c7c5b3c1"), null, 1 },
                    { new Guid("b9bc4d99-c0a1-4a67-85f8-b276d406b8f9"), new Guid("2eb18b3a-eb70-4984-b20e-eba3082dd5c3"), null, 2 },
                    { new Guid("b9ff10df-1674-4c96-8a0b-2c6a5790f58a"), new Guid("e1a08da5-0c3e-4f4c-8f75-3fde7ef6c9b7"), null, 2 },
                    { new Guid("bbc5b71a-f9c8-4bc4-928e-7cf043fbcac5"), new Guid("18b3eeac-a9e1-4098-a094-d9cf9df885df"), null, 1 },
                    { new Guid("bda065a6-57f6-4a7e-9d8e-5a976fa1d57f"), new Guid("7132bc9d-aec5-419a-8594-a427b49a0393"), null, 2 },
                    { new Guid("c2c0d065-3029-4971-ac6b-4bd326256bbe"), new Guid("cf5c7384-0cac-448b-bec1-c4f3eb3769f0"), null, 1 },
                    { new Guid("ce1cd65c-8361-47d1-84c7-f96e6fbc3ed3"), new Guid("18b3eeac-a9e1-4098-a094-d9cf9df885df"), null, 1 },
                    { new Guid("cf817901-5d82-4394-ba7c-f89466bf2384"), new Guid("baff91b9-a58d-4e3c-a938-3fd293b432ed"), null, 0 },
                    { new Guid("d2159c46-4ed0-492f-b189-d16d28cac813"), new Guid("bcecb84c-9f01-4325-b721-9326fb96f2d7"), null, 0 },
                    { new Guid("d3e80909-4838-4a08-bf68-917e7d5de7af"), new Guid("08c709c9-0d6e-4c5c-9b91-77f039dfdb51"), null, 2 },
                    { new Guid("d6946216-8d7c-47d0-b272-d780d3b033dc"), new Guid("b6fda587-5512-4ccc-9294-5e52c7390773"), null, 0 },
                    { new Guid("d6967918-e933-4539-9bdf-0abe2d95b0a7"), new Guid("0d0f72a9-d358-4283-aca5-15811ed0aeb8"), null, 0 },
                    { new Guid("d77275d7-fc21-4288-b44b-28d845cc4a75"), new Guid("ff1ead80-59eb-4049-b0f8-a71d3911dbd5"), null, 1 },
                    { new Guid("d8cd43f1-c23f-4a5c-98d6-ab2ffd9ac952"), new Guid("2ba37673-a6e9-4539-9f68-24921544db84"), null, 0 },
                    { new Guid("d91ae0ee-5b54-43cb-8070-1b8da1b3175c"), new Guid("326b3b91-ecd4-48bd-bddb-3fd788d6ea6a"), null, 0 },
                    { new Guid("e120d5f1-f62d-41ad-bbe9-b3b482575115"), new Guid("2ba37673-a6e9-4539-9f68-24921544db84"), null, 2 },
                    { new Guid("e20c0a42-43ce-4271-a01f-9935df0aa371"), new Guid("2eb18b3a-eb70-4984-b20e-eba3082dd5c3"), null, 2 },
                    { new Guid("e29817aa-3989-4831-903b-450f638e174e"), new Guid("a2d0d869-69bb-4d53-8873-25cad510338b"), null, 1 },
                    { new Guid("e8321ee2-91dd-470f-aba4-6d3195d24b1a"), new Guid("08c709c9-0d6e-4c5c-9b91-77f039dfdb51"), null, 2 },
                    { new Guid("e8377740-6ec2-43fd-8ee8-70508351a088"), new Guid("b6fda587-5512-4ccc-9294-5e52c7390773"), null, 0 },
                    { new Guid("e8744ae4-f299-4ff8-ada8-e23f90845ec3"), new Guid("80ef7321-b0a3-4453-b1ba-6e3ecf1b0d0e"), null, 0 },
                    { new Guid("e8d38cf2-f461-46e8-a4b2-6582436ec489"), new Guid("e1a08da5-0c3e-4f4c-8f75-3fde7ef6c9b7"), null, 2 },
                    { new Guid("e936176e-a4f6-43d4-a060-7e164013496d"), new Guid("7cc4c6a6-cbab-4105-a8a6-c100e5c85d67"), null, 2 },
                    { new Guid("eac4e213-434d-4dd1-ae8d-90b4cd8a4b7f"), new Guid("08c709c9-0d6e-4c5c-9b91-77f039dfdb51"), null, 0 },
                    { new Guid("ec8deff1-7591-4845-920a-2cafb3d5c461"), new Guid("01ac681a-b52e-45cb-8b81-182d1cda3520"), null, 0 },
                    { new Guid("eeec2a56-72c0-46c1-8b3b-e61450030ead"), new Guid("80ef7321-b0a3-4453-b1ba-6e3ecf1b0d0e"), null, 0 },
                    { new Guid("f2adcd4e-f13c-4dfd-84e9-f4da752a3e05"), new Guid("2eb18b3a-eb70-4984-b20e-eba3082dd5c3"), null, 0 },
                    { new Guid("f46924fb-f28f-4374-8175-3f50ee53edb3"), new Guid("18b3eeac-a9e1-4098-a094-d9cf9df885df"), null, 2 },
                    { new Guid("f6cdb6ed-9555-46ba-b8d1-c548c2c9e0ab"), new Guid("b7d20548-b9fa-4ffe-9166-5b42308864a1"), null, 1 },
                    { new Guid("fad3d981-ae34-4af0-8458-f0a9b1dcfc30"), new Guid("2ba37673-a6e9-4539-9f68-24921544db84"), null, 2 },
                    { new Guid("fb6d47ec-fa02-4573-a76d-daba68e75860"), new Guid("c687f724-506d-448b-9511-e686b91f3dda"), null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Borrowings",
                columns: new[] { "Id", "BookId", "BorrowDate", "ReaderId", "ReturnDate" },
                values: new object[,]
                {
                    { new Guid("09803399-58b7-4fa8-a1a9-c7167b6d3615"), new Guid("7006ca97-25b0-4d67-a7a4-b91bc6fc4d16"), new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Local), new Guid("77cff022-1465-49ac-820c-aa5c1ea1b19e"), new DateTime(2024, 2, 21, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("0fe4a8e2-569f-4cf1-bf79-0469b3a1b1fb"), new Guid("4746d247-4e52-40e2-8d46-e9c97fd9748d"), new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Local), new Guid("6a7de3bb-97f4-4a14-b64f-9fc8a8a8b242"), new DateTime(2024, 2, 21, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("115deabf-638d-486c-bbab-ec0455efa5d3"), new Guid("21c536c4-494c-44f1-84c5-be8fe6145b58"), new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Local), new Guid("5d31a024-4e84-4f5e-b86b-04b10d79559e"), new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("1474b77c-c36f-4958-954b-5a34bd490776"), new Guid("c2c0d065-3029-4971-ac6b-4bd326256bbe"), new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Local), new Guid("b757d55d-529d-4cc8-89ae-82036564055e"), new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("17caf637-4546-4c3f-aa46-d16f5a638818"), new Guid("16aa5a85-50e6-4b37-b310-1ca8ffabd155"), new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Local), new Guid("6a7de3bb-97f4-4a14-b64f-9fc8a8a8b242"), new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("255062c4-802b-42d2-b56e-a8ce547a9916"), new Guid("1ca457bb-65a3-4368-87a7-cfb4c60fb149"), new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Local), new Guid("77cff022-1465-49ac-820c-aa5c1ea1b19e"), new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("2c762346-63bf-4c24-857c-8ce60239520f"), new Guid("28e868af-842e-43f2-8a45-447f8e14031c"), new DateTime(2023, 12, 9, 0, 0, 0, 0, DateTimeKind.Local), new Guid("6a7de3bb-97f4-4a14-b64f-9fc8a8a8b242"), new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("2d826f51-fa20-449e-ac91-cf6a80b767f6"), new Guid("ce1cd65c-8361-47d1-84c7-f96e6fbc3ed3"), new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("5d31a024-4e84-4f5e-b86b-04b10d79559e"), new DateTime(2024, 2, 17, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("2e818f47-8877-441e-825c-27898feeda23"), new Guid("78587f17-5dec-4ae4-b4f0-216b0e1866ed"), new DateTime(2023, 12, 18, 0, 0, 0, 0, DateTimeKind.Local), new Guid("77cff022-1465-49ac-820c-aa5c1ea1b19e"), new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("370afe36-391d-4138-a401-bd4870cdbd06"), new Guid("86a88a4e-d4aa-44c7-9a56-e0253efc60fc"), new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Local), new Guid("5d31a024-4e84-4f5e-b86b-04b10d79559e"), new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("39745302-ad15-42df-b432-bc3c16081ea0"), new Guid("bbc5b71a-f9c8-4bc4-928e-7cf043fbcac5"), new DateTime(2023, 12, 21, 0, 0, 0, 0, DateTimeKind.Local), new Guid("5d31a024-4e84-4f5e-b86b-04b10d79559e"), new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("3a545999-e75b-4669-8efd-d9d0efe00964"), new Guid("8600bd80-5d2f-4a26-93c9-8ad950b4f87e"), new DateTime(2023, 12, 20, 0, 0, 0, 0, DateTimeKind.Local), new Guid("5d31a024-4e84-4f5e-b86b-04b10d79559e"), new DateTime(2024, 2, 18, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("4ef8dc2d-7f9a-4c36-b3fe-257b26d8621f"), new Guid("1102a15c-bc66-4291-ac12-8069ef385393"), new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Local), new Guid("77cff022-1465-49ac-820c-aa5c1ea1b19e"), new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("5b8dea20-072e-45c8-b753-07cbd6f70f13"), new Guid("80c3cac4-9b75-431f-93dd-12b3e480281d"), new DateTime(2023, 12, 9, 0, 0, 0, 0, DateTimeKind.Local), new Guid("5d31a024-4e84-4f5e-b86b-04b10d79559e"), new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("6cf8901a-ea30-445b-a1aa-b2b1e5a6e98a"), new Guid("6c3cc738-65cc-4c63-9cfd-8bdcae010a84"), new DateTime(2023, 12, 9, 0, 0, 0, 0, DateTimeKind.Local), new Guid("5d31a024-4e84-4f5e-b86b-04b10d79559e"), new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("6df44fe1-0f6a-4dad-b679-0d9f74ae70b1"), new Guid("a4263179-198f-471a-b7f5-747e2aa05c50"), new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("b757d55d-529d-4cc8-89ae-82036564055e"), new DateTime(2024, 2, 17, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("7f3613da-8b4f-4878-bf93-ffc15f0e06d3"), new Guid("20ec3e8b-8c3b-4dee-9da7-093579c71a4f"), new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("b757d55d-529d-4cc8-89ae-82036564055e"), new DateTime(2024, 2, 17, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("853ceaeb-dcdc-4195-b79c-b5630df37f07"), new Guid("a77ab981-9426-40c4-8289-735bdca7ef3f"), new DateTime(2023, 12, 21, 0, 0, 0, 0, DateTimeKind.Local), new Guid("77cff022-1465-49ac-820c-aa5c1ea1b19e"), new DateTime(2024, 2, 19, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("8d0dea4d-196c-4896-b64a-f0db40456284"), new Guid("079638cb-6d07-4ad6-963f-56cfccee80c7"), new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Local), new Guid("5d31a024-4e84-4f5e-b86b-04b10d79559e"), new DateTime(2024, 2, 12, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("8d71d320-91e6-46be-b208-8f2672bc4ceb"), new Guid("d77275d7-fc21-4288-b44b-28d845cc4a75"), new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Local), new Guid("77cff022-1465-49ac-820c-aa5c1ea1b19e"), new DateTime(2024, 2, 17, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("904038c7-5b75-4c6f-aa69-ed2b15d0d3e3"), new Guid("a908b462-f860-42eb-aba6-f1cbbaab0989"), new DateTime(2023, 12, 20, 0, 0, 0, 0, DateTimeKind.Local), new Guid("6a7de3bb-97f4-4a14-b64f-9fc8a8a8b242"), new DateTime(2024, 2, 18, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("a4d17889-a4b3-40c9-a5d1-fc61b6717785"), new Guid("9aa721a3-8746-43c9-b1eb-6476d2dacacc"), new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Local), new Guid("5d31a024-4e84-4f5e-b86b-04b10d79559e"), new DateTime(2024, 2, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("a781913f-969b-4331-808b-1099106e3699"), new Guid("52f38433-da32-445e-aeed-769c21c5e6de"), new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Local), new Guid("5d31a024-4e84-4f5e-b86b-04b10d79559e"), new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("b1f26b4a-437d-45ca-98fb-89820a02dd5a"), new Guid("77b9510b-5310-4a1f-b5ad-3b310fc432ea"), new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Local), new Guid("5d31a024-4e84-4f5e-b86b-04b10d79559e"), new DateTime(2024, 2, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("b3f3c7bf-a153-4c02-b8ab-e498e142523f"), new Guid("e29817aa-3989-4831-903b-450f638e174e"), new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Local), new Guid("6a7de3bb-97f4-4a14-b64f-9fc8a8a8b242"), new DateTime(2024, 2, 15, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("ba6494fa-5df5-4422-a064-0d134f70225a"), new Guid("7d977b68-ea78-4217-b6a4-a16afdc6b18c"), new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Local), new Guid("b757d55d-529d-4cc8-89ae-82036564055e"), new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("c90959bb-766c-4fd9-8b49-61fbce52b78b"), new Guid("3550d8b6-c72e-47a8-bf8c-3982f945105d"), new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Local), new Guid("77cff022-1465-49ac-820c-aa5c1ea1b19e"), new DateTime(2024, 2, 15, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("cda706c8-5201-4206-ab81-f107eab02844"), new Guid("85c515c7-3ae7-4845-b5ab-043eb413bd22"), new DateTime(2023, 12, 20, 0, 0, 0, 0, DateTimeKind.Local), new Guid("77cff022-1465-49ac-820c-aa5c1ea1b19e"), new DateTime(2024, 2, 18, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("e1a1f9af-dc08-4366-a216-9e06cd0d891c"), new Guid("b64e0711-4ac0-4cf9-aa4d-9e5d2e6167ac"), new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Local), new Guid("b757d55d-529d-4cc8-89ae-82036564055e"), new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("e8974f85-31a8-4569-9422-c694fa0ecc18"), new Guid("f6cdb6ed-9555-46ba-b8d1-c548c2c9e0ab"), new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Local), new Guid("77cff022-1465-49ac-820c-aa5c1ea1b19e"), new DateTime(2024, 2, 9, 0, 0, 0, 0, DateTimeKind.Local) }
                });
        }
    }
}
