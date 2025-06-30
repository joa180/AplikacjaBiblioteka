using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LibSys.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("ae2628ef-e2b9-477e-8b33-98076fe89823"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("009fb077-9761-4d33-9c73-ec4c77af18a5"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0119151f-1e9f-4dff-bc28-b65b64218483"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("052698ea-ea1f-451e-a0ec-110bcea9c50f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0e79a04b-70bc-4f12-b6a4-f62c3f4733ce"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0fb9780a-8d68-4032-bcff-f00fb41aab5e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1019d28c-87f8-4907-82f4-7a950ba66aaf"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("116ee288-345e-45ae-8ba6-5d9c7df8f6b7"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("14c2a934-25f9-4b22-a438-a0a7c29a84a4"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1da2e1a9-5f1e-4543-8d65-45fbdbc85160"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("21961597-151d-468a-9bd9-92f97bc40473"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("229d9dd8-d26d-44e9-8002-3ff3bd6a8c8c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("285facd4-ce7e-4791-a402-f875a415fd0d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2be051ad-d1dc-4580-9525-228225e9e1ff"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("321b91c2-c06b-46f3-a773-6188cc1fa082"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("3f0f998b-c763-42fc-b6b0-d70e908e3c6c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("418d3a47-cbc3-4ba8-8eba-343f56e08d70"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("461a9813-ffcc-4644-8340-0171913abfeb"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("47030a08-65ab-49a6-89b6-dae59324ae33"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("47a8c9fd-20a1-4b85-8112-a6725a99e14b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4a21e4bd-8ab9-47b3-bbed-064222e65d59"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4edcecef-c3f2-441a-a9da-f7a601d6dbd1"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("53d7cf33-f14b-405b-b3d4-bbe1f059d459"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("5625bef7-aa68-4b49-9106-4efa2251634f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("58a5821c-88e8-464f-bc9d-f4eea491293c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("5a77e5e9-b615-4391-a582-f190d93aa135"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("6866d685-383f-478a-9d93-16523ff13301"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("6b0589d2-8d5b-4e75-b874-91b226129339"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("6f67f0da-dff4-4570-a59a-3f05044ee4fe"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("72a4debc-1a67-402a-8bcb-79c55383ff5c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("7949803a-c042-49b5-a74d-447b6da7ec44"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("79500cf5-6620-4a00-9aa2-3cdf96d6e7ad"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("7c1221fd-97a0-4cc0-aab4-ca50c29ed38e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("7e5aba99-b5db-4251-9ab3-d15cbb1cfa36"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("7f65544d-bbba-4095-91a4-c54bef1a4c00"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("81ac4145-5970-43c3-8025-1e2b8e891aa9"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("83fa1eab-2885-48b3-bcda-6e86c1508be3"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("894a9329-9b80-4075-b2cf-2a3a8848679c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8a495b1e-c984-4c60-af60-2446634a6f80"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8a938d3a-86ee-460b-8111-7838f715d05d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8c4c88af-09b1-4eec-acd3-0b9cb34081fa"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8d81c53f-a229-466e-bc6c-5e02fee0e011"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8e57d665-26d0-43fc-88d4-60cb6acadd81"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8e7c2539-98d3-498e-b1f0-48f0b8591de6"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("98a0b921-86f4-469d-936f-8895e5b4d531"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9a2bb7e2-0d02-4ca0-bd57-6753fdb0a333"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9a82de7e-bfce-4b00-9a83-2d73604e542e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9c849553-1383-41f9-b49a-e062977be6db"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a360d498-dfec-4d25-a4a2-035646b2d8dc"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a9f5c3e7-477d-453b-8326-25a2550e8c4d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("aeae4385-1395-42dd-bc73-ed2694b58c24"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b21fd861-83ef-4e4c-b315-31d5c690ba49"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ba5bc79d-1bb7-439d-bb1b-2e0fe6f444fb"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c0673e1c-c9ad-4dcf-baf1-e8d05560a996"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c37404e7-4ae9-4484-aaa3-9b1bbddada19"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("cd5bf0ab-f21b-4fbb-9fcc-d69778c47d2b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d1a2cd43-a87d-49bd-9efd-d60a49b5fafc"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d23190df-046b-417f-8fb9-cdc8f07fcb1a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d6e20e9d-4ab3-4fd1-92cd-734998043266"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d97dc7eb-75ab-4b8c-9fdd-5f3dc6714e1d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e648ce58-5c2c-41d3-8c38-9bfdb6bfc268"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e6761c38-f2c6-4683-bf6d-153988f86ae3"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e791583d-0923-4557-b117-25f066b9ce3e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ed331ec6-673c-4445-bb39-07ef737faae6"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f512a108-d17c-4074-9a21-7d70fb4f33d4"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("fa16c7f5-e09f-4736-be58-fb26dd4b97b9"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("fcd5ddbc-c815-457f-b1ce-a4ad8f10484c"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("16626b58-8ffe-4914-a2c5-2b9503f512eb"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("19c5b850-5919-4160-939e-96ae54cd2384"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("1b0b94b4-19c8-4179-847c-acdde42eb893"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("1e7cbe21-318b-47b2-8dda-efd9830c13c4"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("20fcef83-8104-4061-b502-5db3c8430524"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("24be92f4-863e-4b62-8482-c3e1e664341f"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("29480d1c-8fd4-40ec-83c8-80e4a866cff3"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("2fa140c8-709f-499c-9dc3-d2b1519a3069"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("32000e78-2476-4af8-9b36-0e637a5c0fbf"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("3d82ce65-5b07-47dd-a7d5-3a7a17ba6dcf"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("42b6f07a-cfce-4993-9aaf-f688ffb871e6"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("4d151503-a229-4edb-8288-cf50da0583a0"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("51b0697f-bac5-40dd-94b6-7f158cd041ca"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("66fbb366-83dc-4bdb-99f1-bf1b0627d02d"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("6bd07fcf-6c59-45c3-9660-bd5a06c7c259"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("7090bb20-524c-489e-8017-0d7b09f42542"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("71bc9398-aea6-4171-8515-2030e2251a0b"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("735d21fb-c789-4b42-a59b-46cca70d6003"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("75ab01a4-db49-48b1-9467-d8675fad2189"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("864a4954-3779-46f1-b06b-cd40bcefe916"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("8696a621-725d-418a-a9f1-2947e0b68b71"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("8c1b16cb-5810-48a1-81c9-200ecdf0dead"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("9439f8ab-ab23-4fc5-8461-aa026a314f9e"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("986d8f2b-ad34-4de5-99e8-ed89f14f5aaa"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("99e98e73-1e68-4d85-bcd1-83ea7a06c27b"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("9e40f2a7-5df0-4530-a53d-82ffde4be843"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("adbbc54b-9430-4192-b797-01fbc231f828"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("cfa34d2f-6bde-4a26-b381-1d076295088e"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("d0851b23-1ca4-4f94-b9c4-218c938c7fc7"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("d479fa4e-a0a1-4268-869b-c818b760c1d9"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("d753b49b-cf88-44b7-a6c0-6416aa67a780"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("ee186178-6257-48de-9adc-a958701c4a2b"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("f3f9fff2-f565-4588-a4e3-ff7b81882094"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("f8c68237-2726-41a6-aa86-4e3862155c2a"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("198d2b19-50f2-4434-b04c-33a6cbe2f4dd"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("3a9e3864-109a-4fea-881b-a3e1c0719e7d"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("591b8158-660a-4918-97c8-04024d921cb9"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("77e9fd0e-47f1-414d-a1f1-7cccd06f94ef"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("7ce7c1c3-20d4-46c2-b175-229585df5756"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("819c3de3-483f-4223-a8b4-7ac634930de3"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("bc8f4a9d-91bc-44f4-813a-c86fcc7b5c83"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("dfb274b1-e5e7-41ac-b4ab-1a1de518c52b"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("e743a086-aa56-470e-8cb9-abb62d10208c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("179f4cb7-881d-44d6-bcd4-b61807e7aa35"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1f197941-ed4c-4cdf-97c2-73de5f27480e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2f25968c-c628-480f-9854-7125222da1f2"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("3df28a5c-7b25-49ff-8ec6-9380d58bbe9d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("3e5bbec0-6770-4943-87b9-a10b9cbdee40"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4036633f-fad8-43e7-bacb-83c65c81859f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("49133f99-4649-4872-ae98-4c562996f8a1"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("53751848-6eb1-4309-a2d7-603ee677845d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("596f5c30-d1de-4ba7-a3ac-67737f83c921"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("5f2773aa-8b00-447a-9322-2216963d231a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("64131acf-e2d7-4cb0-bc87-ced22c1c4ef0"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("660f8dc9-86b3-46bb-ba0b-e3e5b069d258"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("67dc1965-14f8-4532-b0c4-3a829745e5b7"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("69ae25c2-269d-4b31-b61d-a3306efdeabe"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("720b65ab-f427-4d3d-9d06-68d7e31aa07d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("751ba902-f09f-4f43-9ff1-15cb13597ab2"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("7980be9f-489b-4d6a-9ae1-034b41921f7c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("7c5aa709-dd4f-4c7a-80de-9153fca4644f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("7d04fdc7-34df-4f05-a1d6-d05d9ab43327"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8479b6c4-f521-45ac-98ff-5a829a02c16b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9eca2aee-d62b-4ea5-8bd8-55d964e63530"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a40a31b4-a136-4313-8a00-753182ba4cbb"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b508d4ac-d1ee-4911-8101-6465e3edd909"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b5d52925-e699-4ee4-986e-f58fc7bfe5e1"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ba6bb43d-2744-4fc5-bb4c-bcf5ed9f387c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("bded5e72-2d26-4567-9cab-29c071b8f86e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("cd00945e-6633-4ab3-9b85-c2762bdbe7f8"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d5859648-78d2-4fb2-b4f3-b2913013d06a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e2ae0e12-11b3-4802-8db1-b62de44aa283"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ea233f86-34d6-44ee-ab5f-4ff7fa0dca02"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f5b74e80-5f91-4206-a81c-bcbb5a630452"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("fb98db2a-652d-4a6e-a0b7-cd266a3fabd7"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("fc5cb925-b360-44f8-93fa-3cfde09132ea"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("fde7811e-9b87-4806-a2d5-ddc024a6705c"));

            migrationBuilder.DeleteData(
                table: "Readers",
                keyColumn: "Id",
                keyValue: new Guid("6ef43601-4194-4b07-a2c3-fee8637af4cf"));

            migrationBuilder.DeleteData(
                table: "Readers",
                keyColumn: "Id",
                keyValue: new Guid("85d3f82a-c4c6-42e7-af13-9528218d14fe"));

            migrationBuilder.DeleteData(
                table: "Readers",
                keyColumn: "Id",
                keyValue: new Guid("b12d8bfe-245e-4967-a3f9-8e780c2806e3"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("0d861549-568b-425f-a078-ff64915fba9e"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("1462068c-ded0-4129-9d47-62e23c665b78"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("28472a07-ced7-4e78-ad6e-f6f8f33411ac"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("3723afbf-c3bb-4a4a-aadc-739c8af1bb7b"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("3ce3efa2-c19b-4430-80e5-1a36366a4d1f"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("410215ae-93bd-4e2e-bb40-613960dca85e"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("4a1f3dd9-ac98-4d0e-b368-b07e2542113d"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("51697d68-4f1d-4dd0-9165-759322a1273f"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("6951fa30-b5f1-4fd7-b831-1557a6a58cf6"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("6b01b27e-0c4f-47f4-9dd0-2162b51508e0"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("6d1fc983-bfb4-4b60-a9c3-676290deb47a"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("81b4c419-807a-4d2f-91dc-6abf94183e2c"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("9c38aca7-d837-40dc-a9ae-4b66819de030"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("afa07347-7c04-46d4-8241-dd969dbccbac"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("b8f89091-0e70-4221-a708-778eaedb2b6c"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("d29c7fcf-864a-4a9d-ae7d-97e8e50e9a12"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("f68add18-030a-48ef-950b-6944914e8ab0"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("f74e1f65-932a-4091-90fc-23914bd6be2e"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("f76905ac-2e81-49e6-a780-b674d91c0e9b"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("f87c6b22-dd61-468e-8565-b6d236bc5596"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "3dc9ebbc-5922-4be0-a806-db5d353b2e68", "AQAAAAIAAYagAAAAEPjPmy8yb6w+Bgexl67VP5CITdKaaGr+P0eU5kQHHiiqbQmVWhHkg05Zy61WNHE5pA==", "92c3ef5c-53bd-4d53-abd7-a222c777bc07" });

            migrationBuilder.InsertData(
                table: "BookDefinitions",
                columns: new[] { "Id", "Author", "CoverImagePath", "Title" },
                values: new object[,]
                {
                    { new Guid("0d861549-568b-425f-a078-ff64915fba9e"), "Cassandra Clare", null, "Miasto upadłych aniołów" },
                    { new Guid("1462068c-ded0-4129-9d47-62e23c665b78"), "J.K. Rowling", null, "Harry Potter i więzień Azkabanu" },
                    { new Guid("198d2b19-50f2-4434-b04c-33a6cbe2f4dd"), "Stieg Larsson", null, "Mężczyźni, którzy nienawidzą kobiet" },
                    { new Guid("28472a07-ced7-4e78-ad6e-f6f8f33411ac"), "Veronica Roth", null, "Niezgodna" },
                    { new Guid("3723afbf-c3bb-4a4a-aadc-739c8af1bb7b"), "George R.R. Martin", null, "Gra o tron (edycja ilustrowana)" },
                    { new Guid("3a9e3864-109a-4fea-881b-a3e1c0719e7d"), "Stanisław Wyspiański", null, "Wesele" },
                    { new Guid("3ce3efa2-c19b-4430-80e5-1a36366a4d1f"), "George R.R. Martin", null, "Nawałnica mieczy: Stal i śnieg" },
                    { new Guid("410215ae-93bd-4e2e-bb40-613960dca85e"), "Camilla Läckberg", null, "Księżniczka z lodu" },
                    { new Guid("4a1f3dd9-ac98-4d0e-b368-b07e2542113d"), "Andrzej Ziemiański", null, "Achaja. Tom I" },
                    { new Guid("51697d68-4f1d-4dd0-9165-759322a1273f"), "Jo Nesbø", null, "Człowiek nietoperz" },
                    { new Guid("591b8158-660a-4918-97c8-04024d921cb9"), "J.K. Rowling", null, "Harry Potter i Książę Półkrwi" },
                    { new Guid("6951fa30-b5f1-4fd7-b831-1557a6a58cf6"), "Camilla Läckberg", null, "Niemiecki bękart" },
                    { new Guid("6b01b27e-0c4f-47f4-9dd0-2162b51508e0"), "J.K. Rowling", null, "Harry Potter i Czara Ognia" },
                    { new Guid("6d1fc983-bfb4-4b60-a9c3-676290deb47a"), "Camilla Läckberg", null, "Kaznodzieja" },
                    { new Guid("77e9fd0e-47f1-414d-a1f1-7cccd06f94ef"), "Johann Wolfgang von Goethe", null, "Cierpienia młodego Wertera" },
                    { new Guid("7ce7c1c3-20d4-46c2-b175-229585df5756"), "Camilla Läckberg", null, "Ofiara losu" },
                    { new Guid("819c3de3-483f-4223-a8b4-7ac634930de3"), "J.K. Rowling", null, "Harry Potter i Zakon Feniksa" },
                    { new Guid("81b4c419-807a-4d2f-91dc-6abf94183e2c"), "Andrzej Sapkowski", null, "Narrenturm" },
                    { new Guid("9c38aca7-d837-40dc-a9ae-4b66819de030"), "Camilla Läckberg", null, "Kamieniarz" },
                    { new Guid("ae2628ef-e2b9-477e-8b33-98076fe89823"), "Kornel Makuszyński", null, "Szatan z siódmej klasy" },
                    { new Guid("afa07347-7c04-46d4-8241-dd969dbccbac"), "J.K. Rowling", null, "Harry Potter i Komnata Tajemnic" },
                    { new Guid("b8f89091-0e70-4221-a708-778eaedb2b6c"), "Christopher Paolini", null, "Dziedzictwo" },
                    { new Guid("bc8f4a9d-91bc-44f4-813a-c86fcc7b5c83"), "J.K. Rowling, Jack Thorne", null, "Harry Potter i Przeklęte Dziecko" },
                    { new Guid("d29c7fcf-864a-4a9d-ae7d-97e8e50e9a12"), "William Shakespeare", null, "Romeo i Julia" },
                    { new Guid("dfb274b1-e5e7-41ac-b4ab-1a1de518c52b"), "J.K. Rowling", null, "Harry Potter i Kamień Filozoficzny" },
                    { new Guid("e743a086-aa56-470e-8cb9-abb62d10208c"), "Dan Brown", null, "Inferno" },
                    { new Guid("f68add18-030a-48ef-950b-6944914e8ab0"), "Juliusz Słowacki", null, "Balladyna" },
                    { new Guid("f74e1f65-932a-4091-90fc-23914bd6be2e"), "Juliusz Słowacki", null, "Kordian" },
                    { new Guid("f76905ac-2e81-49e6-a780-b674d91c0e9b"), "George R.R. Martin", null, "Starcie królów (edycja ilustrowana)" },
                    { new Guid("f87c6b22-dd61-468e-8565-b6d236bc5596"), "Władysław Stanisław Reymont", null, "Chłopi" }
                });

            migrationBuilder.InsertData(
                table: "Readers",
                columns: new[] { "Id", "City", "Code", "Name", "Street", "UserId" },
                values: new object[,]
                {
                    { new Guid("6ef43601-4194-4b07-a2c3-fee8637af4cf"), "Poznań", "61-111", "Tomasz Rydz", "Garbary 1", null },
                    { new Guid("85d3f82a-c4c6-42e7-af13-9528218d14fe"), "Poznań", "61-311", "Jan Nowak", "Wieżowa 3", null },
                    { new Guid("b12d8bfe-245e-4967-a3f9-8e780c2806e3"), "Poznań", "61-111", "Aleksandra Mechrzycka", "Solna 2", null }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "BookDefinitionId", "Comment", "Status" },
                values: new object[,]
                {
                    { new Guid("009fb077-9761-4d33-9c73-ec4c77af18a5"), new Guid("dfb274b1-e5e7-41ac-b4ab-1a1de518c52b"), null, 2 },
                    { new Guid("0119151f-1e9f-4dff-bc28-b65b64218483"), new Guid("dfb274b1-e5e7-41ac-b4ab-1a1de518c52b"), null, 0 },
                    { new Guid("052698ea-ea1f-451e-a0ec-110bcea9c50f"), new Guid("28472a07-ced7-4e78-ad6e-f6f8f33411ac"), null, 0 },
                    { new Guid("0e79a04b-70bc-4f12-b6a4-f62c3f4733ce"), new Guid("6951fa30-b5f1-4fd7-b831-1557a6a58cf6"), null, 0 },
                    { new Guid("0fb9780a-8d68-4032-bcff-f00fb41aab5e"), new Guid("591b8158-660a-4918-97c8-04024d921cb9"), null, 0 },
                    { new Guid("1019d28c-87f8-4907-82f4-7a950ba66aaf"), new Guid("f74e1f65-932a-4091-90fc-23914bd6be2e"), null, 2 },
                    { new Guid("116ee288-345e-45ae-8ba6-5d9c7df8f6b7"), new Guid("f87c6b22-dd61-468e-8565-b6d236bc5596"), null, 2 },
                    { new Guid("14c2a934-25f9-4b22-a438-a0a7c29a84a4"), new Guid("410215ae-93bd-4e2e-bb40-613960dca85e"), null, 2 },
                    { new Guid("179f4cb7-881d-44d6-bcd4-b61807e7aa35"), new Guid("f87c6b22-dd61-468e-8565-b6d236bc5596"), null, 1 },
                    { new Guid("1da2e1a9-5f1e-4543-8d65-45fbdbc85160"), new Guid("81b4c419-807a-4d2f-91dc-6abf94183e2c"), null, 2 },
                    { new Guid("1f197941-ed4c-4cdf-97c2-73de5f27480e"), new Guid("6b01b27e-0c4f-47f4-9dd0-2162b51508e0"), null, 1 },
                    { new Guid("21961597-151d-468a-9bd9-92f97bc40473"), new Guid("77e9fd0e-47f1-414d-a1f1-7cccd06f94ef"), null, 0 },
                    { new Guid("229d9dd8-d26d-44e9-8002-3ff3bd6a8c8c"), new Guid("f74e1f65-932a-4091-90fc-23914bd6be2e"), null, 2 },
                    { new Guid("285facd4-ce7e-4791-a402-f875a415fd0d"), new Guid("3ce3efa2-c19b-4430-80e5-1a36366a4d1f"), null, 2 },
                    { new Guid("2be051ad-d1dc-4580-9525-228225e9e1ff"), new Guid("e743a086-aa56-470e-8cb9-abb62d10208c"), null, 2 },
                    { new Guid("2f25968c-c628-480f-9854-7125222da1f2"), new Guid("afa07347-7c04-46d4-8241-dd969dbccbac"), null, 1 },
                    { new Guid("321b91c2-c06b-46f3-a773-6188cc1fa082"), new Guid("6d1fc983-bfb4-4b60-a9c3-676290deb47a"), null, 2 },
                    { new Guid("3df28a5c-7b25-49ff-8ec6-9380d58bbe9d"), new Guid("3723afbf-c3bb-4a4a-aadc-739c8af1bb7b"), null, 1 },
                    { new Guid("3e5bbec0-6770-4943-87b9-a10b9cbdee40"), new Guid("6d1fc983-bfb4-4b60-a9c3-676290deb47a"), null, 1 },
                    { new Guid("3f0f998b-c763-42fc-b6b0-d70e908e3c6c"), new Guid("e743a086-aa56-470e-8cb9-abb62d10208c"), null, 0 },
                    { new Guid("4036633f-fad8-43e7-bacb-83c65c81859f"), new Guid("410215ae-93bd-4e2e-bb40-613960dca85e"), null, 1 },
                    { new Guid("418d3a47-cbc3-4ba8-8eba-343f56e08d70"), new Guid("77e9fd0e-47f1-414d-a1f1-7cccd06f94ef"), null, 2 },
                    { new Guid("461a9813-ffcc-4644-8340-0171913abfeb"), new Guid("1462068c-ded0-4129-9d47-62e23c665b78"), null, 2 },
                    { new Guid("47030a08-65ab-49a6-89b6-dae59324ae33"), new Guid("3a9e3864-109a-4fea-881b-a3e1c0719e7d"), null, 0 },
                    { new Guid("47a8c9fd-20a1-4b85-8112-a6725a99e14b"), new Guid("77e9fd0e-47f1-414d-a1f1-7cccd06f94ef"), null, 2 },
                    { new Guid("49133f99-4649-4872-ae98-4c562996f8a1"), new Guid("9c38aca7-d837-40dc-a9ae-4b66819de030"), null, 1 },
                    { new Guid("4a21e4bd-8ab9-47b3-bbed-064222e65d59"), new Guid("4a1f3dd9-ac98-4d0e-b368-b07e2542113d"), null, 2 },
                    { new Guid("4edcecef-c3f2-441a-a9da-f7a601d6dbd1"), new Guid("b8f89091-0e70-4221-a708-778eaedb2b6c"), null, 2 },
                    { new Guid("53751848-6eb1-4309-a2d7-603ee677845d"), new Guid("28472a07-ced7-4e78-ad6e-f6f8f33411ac"), null, 1 },
                    { new Guid("53d7cf33-f14b-405b-b3d4-bbe1f059d459"), new Guid("7ce7c1c3-20d4-46c2-b175-229585df5756"), null, 2 },
                    { new Guid("5625bef7-aa68-4b49-9106-4efa2251634f"), new Guid("819c3de3-483f-4223-a8b4-7ac634930de3"), null, 0 },
                    { new Guid("58a5821c-88e8-464f-bc9d-f4eea491293c"), new Guid("f76905ac-2e81-49e6-a780-b674d91c0e9b"), null, 0 },
                    { new Guid("596f5c30-d1de-4ba7-a3ac-67737f83c921"), new Guid("51697d68-4f1d-4dd0-9165-759322a1273f"), null, 1 },
                    { new Guid("5a77e5e9-b615-4391-a582-f190d93aa135"), new Guid("e743a086-aa56-470e-8cb9-abb62d10208c"), null, 2 },
                    { new Guid("5f2773aa-8b00-447a-9322-2216963d231a"), new Guid("3ce3efa2-c19b-4430-80e5-1a36366a4d1f"), null, 1 },
                    { new Guid("64131acf-e2d7-4cb0-bc87-ced22c1c4ef0"), new Guid("f74e1f65-932a-4091-90fc-23914bd6be2e"), null, 1 },
                    { new Guid("660f8dc9-86b3-46bb-ba0b-e3e5b069d258"), new Guid("f68add18-030a-48ef-950b-6944914e8ab0"), null, 1 },
                    { new Guid("67dc1965-14f8-4532-b0c4-3a829745e5b7"), new Guid("b8f89091-0e70-4221-a708-778eaedb2b6c"), null, 1 },
                    { new Guid("6866d685-383f-478a-9d93-16523ff13301"), new Guid("dfb274b1-e5e7-41ac-b4ab-1a1de518c52b"), null, 2 },
                    { new Guid("69ae25c2-269d-4b31-b61d-a3306efdeabe"), new Guid("3ce3efa2-c19b-4430-80e5-1a36366a4d1f"), null, 1 },
                    { new Guid("6b0589d2-8d5b-4e75-b874-91b226129339"), new Guid("819c3de3-483f-4223-a8b4-7ac634930de3"), null, 2 },
                    { new Guid("6f67f0da-dff4-4570-a59a-3f05044ee4fe"), new Guid("3ce3efa2-c19b-4430-80e5-1a36366a4d1f"), null, 0 },
                    { new Guid("720b65ab-f427-4d3d-9d06-68d7e31aa07d"), new Guid("afa07347-7c04-46d4-8241-dd969dbccbac"), null, 1 },
                    { new Guid("72a4debc-1a67-402a-8bcb-79c55383ff5c"), new Guid("81b4c419-807a-4d2f-91dc-6abf94183e2c"), null, 0 },
                    { new Guid("751ba902-f09f-4f43-9ff1-15cb13597ab2"), new Guid("d29c7fcf-864a-4a9d-ae7d-97e8e50e9a12"), null, 1 },
                    { new Guid("7949803a-c042-49b5-a74d-447b6da7ec44"), new Guid("9c38aca7-d837-40dc-a9ae-4b66819de030"), null, 2 },
                    { new Guid("79500cf5-6620-4a00-9aa2-3cdf96d6e7ad"), new Guid("7ce7c1c3-20d4-46c2-b175-229585df5756"), null, 0 },
                    { new Guid("7980be9f-489b-4d6a-9ae1-034b41921f7c"), new Guid("6b01b27e-0c4f-47f4-9dd0-2162b51508e0"), null, 1 },
                    { new Guid("7c1221fd-97a0-4cc0-aab4-ca50c29ed38e"), new Guid("f68add18-030a-48ef-950b-6944914e8ab0"), null, 2 },
                    { new Guid("7c5aa709-dd4f-4c7a-80de-9153fca4644f"), new Guid("4a1f3dd9-ac98-4d0e-b368-b07e2542113d"), null, 1 },
                    { new Guid("7d04fdc7-34df-4f05-a1d6-d05d9ab43327"), new Guid("81b4c419-807a-4d2f-91dc-6abf94183e2c"), null, 1 },
                    { new Guid("7e5aba99-b5db-4251-9ab3-d15cbb1cfa36"), new Guid("d29c7fcf-864a-4a9d-ae7d-97e8e50e9a12"), null, 0 },
                    { new Guid("7f65544d-bbba-4095-91a4-c54bef1a4c00"), new Guid("f76905ac-2e81-49e6-a780-b674d91c0e9b"), null, 0 },
                    { new Guid("81ac4145-5970-43c3-8025-1e2b8e891aa9"), new Guid("591b8158-660a-4918-97c8-04024d921cb9"), null, 2 },
                    { new Guid("83fa1eab-2885-48b3-bcda-6e86c1508be3"), new Guid("6b01b27e-0c4f-47f4-9dd0-2162b51508e0"), null, 2 },
                    { new Guid("8479b6c4-f521-45ac-98ff-5a829a02c16b"), new Guid("81b4c419-807a-4d2f-91dc-6abf94183e2c"), null, 1 },
                    { new Guid("894a9329-9b80-4075-b2cf-2a3a8848679c"), new Guid("410215ae-93bd-4e2e-bb40-613960dca85e"), null, 2 },
                    { new Guid("8a495b1e-c984-4c60-af60-2446634a6f80"), new Guid("9c38aca7-d837-40dc-a9ae-4b66819de030"), null, 0 },
                    { new Guid("8a938d3a-86ee-460b-8111-7838f715d05d"), new Guid("9c38aca7-d837-40dc-a9ae-4b66819de030"), null, 2 },
                    { new Guid("8c4c88af-09b1-4eec-acd3-0b9cb34081fa"), new Guid("9c38aca7-d837-40dc-a9ae-4b66819de030"), null, 0 },
                    { new Guid("8d81c53f-a229-466e-bc6c-5e02fee0e011"), new Guid("3a9e3864-109a-4fea-881b-a3e1c0719e7d"), null, 2 },
                    { new Guid("8e57d665-26d0-43fc-88d4-60cb6acadd81"), new Guid("f74e1f65-932a-4091-90fc-23914bd6be2e"), null, 0 },
                    { new Guid("8e7c2539-98d3-498e-b1f0-48f0b8591de6"), new Guid("0d861549-568b-425f-a078-ff64915fba9e"), null, 0 },
                    { new Guid("98a0b921-86f4-469d-936f-8895e5b4d531"), new Guid("410215ae-93bd-4e2e-bb40-613960dca85e"), null, 2 },
                    { new Guid("9a2bb7e2-0d02-4ca0-bd57-6753fdb0a333"), new Guid("591b8158-660a-4918-97c8-04024d921cb9"), null, 0 },
                    { new Guid("9a82de7e-bfce-4b00-9a83-2d73604e542e"), new Guid("819c3de3-483f-4223-a8b4-7ac634930de3"), null, 0 },
                    { new Guid("9c849553-1383-41f9-b49a-e062977be6db"), new Guid("f74e1f65-932a-4091-90fc-23914bd6be2e"), null, 0 },
                    { new Guid("9eca2aee-d62b-4ea5-8bd8-55d964e63530"), new Guid("6951fa30-b5f1-4fd7-b831-1557a6a58cf6"), null, 1 },
                    { new Guid("a360d498-dfec-4d25-a4a2-035646b2d8dc"), new Guid("4a1f3dd9-ac98-4d0e-b368-b07e2542113d"), null, 2 },
                    { new Guid("a40a31b4-a136-4313-8a00-753182ba4cbb"), new Guid("81b4c419-807a-4d2f-91dc-6abf94183e2c"), null, 1 },
                    { new Guid("a9f5c3e7-477d-453b-8326-25a2550e8c4d"), new Guid("6951fa30-b5f1-4fd7-b831-1557a6a58cf6"), null, 2 },
                    { new Guid("aeae4385-1395-42dd-bc73-ed2694b58c24"), new Guid("198d2b19-50f2-4434-b04c-33a6cbe2f4dd"), null, 0 },
                    { new Guid("b21fd861-83ef-4e4c-b315-31d5c690ba49"), new Guid("3ce3efa2-c19b-4430-80e5-1a36366a4d1f"), null, 2 },
                    { new Guid("b508d4ac-d1ee-4911-8101-6465e3edd909"), new Guid("6951fa30-b5f1-4fd7-b831-1557a6a58cf6"), null, 1 },
                    { new Guid("b5d52925-e699-4ee4-986e-f58fc7bfe5e1"), new Guid("81b4c419-807a-4d2f-91dc-6abf94183e2c"), null, 1 },
                    { new Guid("ba5bc79d-1bb7-439d-bb1b-2e0fe6f444fb"), new Guid("afa07347-7c04-46d4-8241-dd969dbccbac"), null, 0 },
                    { new Guid("ba6bb43d-2744-4fc5-bb4c-bcf5ed9f387c"), new Guid("f87c6b22-dd61-468e-8565-b6d236bc5596"), null, 1 },
                    { new Guid("bded5e72-2d26-4567-9cab-29c071b8f86e"), new Guid("6b01b27e-0c4f-47f4-9dd0-2162b51508e0"), null, 1 },
                    { new Guid("c0673e1c-c9ad-4dcf-baf1-e8d05560a996"), new Guid("819c3de3-483f-4223-a8b4-7ac634930de3"), null, 0 },
                    { new Guid("c37404e7-4ae9-4484-aaa3-9b1bbddada19"), new Guid("6b01b27e-0c4f-47f4-9dd0-2162b51508e0"), null, 0 },
                    { new Guid("cd00945e-6633-4ab3-9b85-c2762bdbe7f8"), new Guid("0d861549-568b-425f-a078-ff64915fba9e"), null, 1 },
                    { new Guid("cd5bf0ab-f21b-4fbb-9fcc-d69778c47d2b"), new Guid("6b01b27e-0c4f-47f4-9dd0-2162b51508e0"), null, 0 },
                    { new Guid("d1a2cd43-a87d-49bd-9efd-d60a49b5fafc"), new Guid("410215ae-93bd-4e2e-bb40-613960dca85e"), null, 0 },
                    { new Guid("d23190df-046b-417f-8fb9-cdc8f07fcb1a"), new Guid("819c3de3-483f-4223-a8b4-7ac634930de3"), null, 0 },
                    { new Guid("d5859648-78d2-4fb2-b4f3-b2913013d06a"), new Guid("4a1f3dd9-ac98-4d0e-b368-b07e2542113d"), null, 1 },
                    { new Guid("d6e20e9d-4ab3-4fd1-92cd-734998043266"), new Guid("dfb274b1-e5e7-41ac-b4ab-1a1de518c52b"), null, 0 },
                    { new Guid("d97dc7eb-75ab-4b8c-9fdd-5f3dc6714e1d"), new Guid("9c38aca7-d837-40dc-a9ae-4b66819de030"), null, 0 },
                    { new Guid("e2ae0e12-11b3-4802-8db1-b62de44aa283"), new Guid("28472a07-ced7-4e78-ad6e-f6f8f33411ac"), null, 1 },
                    { new Guid("e648ce58-5c2c-41d3-8c38-9bfdb6bfc268"), new Guid("51697d68-4f1d-4dd0-9165-759322a1273f"), null, 0 },
                    { new Guid("e6761c38-f2c6-4683-bf6d-153988f86ae3"), new Guid("bc8f4a9d-91bc-44f4-813a-c86fcc7b5c83"), null, 2 },
                    { new Guid("e791583d-0923-4557-b117-25f066b9ce3e"), new Guid("f76905ac-2e81-49e6-a780-b674d91c0e9b"), null, 2 },
                    { new Guid("ea233f86-34d6-44ee-ab5f-4ff7fa0dca02"), new Guid("28472a07-ced7-4e78-ad6e-f6f8f33411ac"), null, 1 },
                    { new Guid("ed331ec6-673c-4445-bb39-07ef737faae6"), new Guid("198d2b19-50f2-4434-b04c-33a6cbe2f4dd"), null, 2 },
                    { new Guid("f512a108-d17c-4074-9a21-7d70fb4f33d4"), new Guid("7ce7c1c3-20d4-46c2-b175-229585df5756"), null, 0 },
                    { new Guid("f5b74e80-5f91-4206-a81c-bcbb5a630452"), new Guid("6b01b27e-0c4f-47f4-9dd0-2162b51508e0"), null, 1 },
                    { new Guid("fa16c7f5-e09f-4736-be58-fb26dd4b97b9"), new Guid("afa07347-7c04-46d4-8241-dd969dbccbac"), null, 0 },
                    { new Guid("fb98db2a-652d-4a6e-a0b7-cd266a3fabd7"), new Guid("1462068c-ded0-4129-9d47-62e23c665b78"), null, 1 },
                    { new Guid("fc5cb925-b360-44f8-93fa-3cfde09132ea"), new Guid("f76905ac-2e81-49e6-a780-b674d91c0e9b"), null, 1 },
                    { new Guid("fcd5ddbc-c815-457f-b1ce-a4ad8f10484c"), new Guid("6d1fc983-bfb4-4b60-a9c3-676290deb47a"), null, 0 },
                    { new Guid("fde7811e-9b87-4806-a2d5-ddc024a6705c"), new Guid("afa07347-7c04-46d4-8241-dd969dbccbac"), null, 1 }
                });

            migrationBuilder.InsertData(
                table: "Borrowings",
                columns: new[] { "Id", "BookId", "BorrowDate", "ReaderId", "ReturnDate" },
                values: new object[,]
                {
                    { new Guid("16626b58-8ffe-4914-a2c5-2b9503f512eb"), new Guid("cd00945e-6633-4ab3-9b85-c2762bdbe7f8"), new DateTime(2025, 5, 3, 0, 0, 0, 0, DateTimeKind.Local), new Guid("6ef43601-4194-4b07-a2c3-fee8637af4cf"), new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("19c5b850-5919-4160-939e-96ae54cd2384"), new Guid("e2ae0e12-11b3-4802-8db1-b62de44aa283"), new DateTime(2025, 5, 10, 0, 0, 0, 0, DateTimeKind.Local), new Guid("5d31a024-4e84-4f5e-b86b-04b10d79559e"), new DateTime(2025, 7, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("1b0b94b4-19c8-4179-847c-acdde42eb893"), new Guid("8479b6c4-f521-45ac-98ff-5a829a02c16b"), new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Local), new Guid("5d31a024-4e84-4f5e-b86b-04b10d79559e"), new DateTime(2025, 6, 30, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("1e7cbe21-318b-47b2-8dda-efd9830c13c4"), new Guid("3e5bbec0-6770-4943-87b9-a10b9cbdee40"), new DateTime(2025, 5, 2, 0, 0, 0, 0, DateTimeKind.Local), new Guid("85d3f82a-c4c6-42e7-af13-9528218d14fe"), new DateTime(2025, 7, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("20fcef83-8104-4061-b502-5db3c8430524"), new Guid("ea233f86-34d6-44ee-ab5f-4ff7fa0dca02"), new DateTime(2025, 4, 30, 0, 0, 0, 0, DateTimeKind.Local), new Guid("85d3f82a-c4c6-42e7-af13-9528218d14fe"), new DateTime(2025, 6, 29, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("24be92f4-863e-4b62-8482-c3e1e664341f"), new Guid("fde7811e-9b87-4806-a2d5-ddc024a6705c"), new DateTime(2025, 5, 7, 0, 0, 0, 0, DateTimeKind.Local), new Guid("5d31a024-4e84-4f5e-b86b-04b10d79559e"), new DateTime(2025, 7, 6, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("29480d1c-8fd4-40ec-83c8-80e4a866cff3"), new Guid("3df28a5c-7b25-49ff-8ec6-9380d58bbe9d"), new DateTime(2025, 5, 3, 0, 0, 0, 0, DateTimeKind.Local), new Guid("6ef43601-4194-4b07-a2c3-fee8637af4cf"), new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("2fa140c8-709f-499c-9dc3-d2b1519a3069"), new Guid("53751848-6eb1-4309-a2d7-603ee677845d"), new DateTime(2025, 5, 8, 0, 0, 0, 0, DateTimeKind.Local), new Guid("5d31a024-4e84-4f5e-b86b-04b10d79559e"), new DateTime(2025, 7, 7, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("32000e78-2476-4af8-9b36-0e637a5c0fbf"), new Guid("179f4cb7-881d-44d6-bcd4-b61807e7aa35"), new DateTime(2025, 5, 8, 0, 0, 0, 0, DateTimeKind.Local), new Guid("5d31a024-4e84-4f5e-b86b-04b10d79559e"), new DateTime(2025, 7, 7, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("3d82ce65-5b07-47dd-a7d5-3a7a17ba6dcf"), new Guid("b508d4ac-d1ee-4911-8101-6465e3edd909"), new DateTime(2025, 5, 14, 0, 0, 0, 0, DateTimeKind.Local), new Guid("85d3f82a-c4c6-42e7-af13-9528218d14fe"), new DateTime(2025, 7, 13, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("42b6f07a-cfce-4993-9aaf-f688ffb871e6"), new Guid("9eca2aee-d62b-4ea5-8bd8-55d964e63530"), new DateTime(2025, 5, 8, 0, 0, 0, 0, DateTimeKind.Local), new Guid("b12d8bfe-245e-4967-a3f9-8e780c2806e3"), new DateTime(2025, 7, 7, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("4d151503-a229-4edb-8288-cf50da0583a0"), new Guid("7c5aa709-dd4f-4c7a-80de-9153fca4644f"), new DateTime(2025, 5, 14, 0, 0, 0, 0, DateTimeKind.Local), new Guid("85d3f82a-c4c6-42e7-af13-9528218d14fe"), new DateTime(2025, 7, 13, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("51b0697f-bac5-40dd-94b6-7f158cd041ca"), new Guid("2f25968c-c628-480f-9854-7125222da1f2"), new DateTime(2025, 5, 5, 0, 0, 0, 0, DateTimeKind.Local), new Guid("b12d8bfe-245e-4967-a3f9-8e780c2806e3"), new DateTime(2025, 7, 4, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("66fbb366-83dc-4bdb-99f1-bf1b0627d02d"), new Guid("bded5e72-2d26-4567-9cab-29c071b8f86e"), new DateTime(2025, 5, 6, 0, 0, 0, 0, DateTimeKind.Local), new Guid("5d31a024-4e84-4f5e-b86b-04b10d79559e"), new DateTime(2025, 7, 5, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("6bd07fcf-6c59-45c3-9660-bd5a06c7c259"), new Guid("49133f99-4649-4872-ae98-4c562996f8a1"), new DateTime(2025, 5, 5, 0, 0, 0, 0, DateTimeKind.Local), new Guid("6ef43601-4194-4b07-a2c3-fee8637af4cf"), new DateTime(2025, 7, 4, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("7090bb20-524c-489e-8017-0d7b09f42542"), new Guid("ba6bb43d-2744-4fc5-bb4c-bcf5ed9f387c"), new DateTime(2025, 5, 5, 0, 0, 0, 0, DateTimeKind.Local), new Guid("85d3f82a-c4c6-42e7-af13-9528218d14fe"), new DateTime(2025, 7, 4, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("71bc9398-aea6-4171-8515-2030e2251a0b"), new Guid("fc5cb925-b360-44f8-93fa-3cfde09132ea"), new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Local), new Guid("b12d8bfe-245e-4967-a3f9-8e780c2806e3"), new DateTime(2025, 6, 30, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("735d21fb-c789-4b42-a59b-46cca70d6003"), new Guid("5f2773aa-8b00-447a-9322-2216963d231a"), new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Local), new Guid("85d3f82a-c4c6-42e7-af13-9528218d14fe"), new DateTime(2025, 6, 30, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("75ab01a4-db49-48b1-9467-d8675fad2189"), new Guid("7d04fdc7-34df-4f05-a1d6-d05d9ab43327"), new DateTime(2025, 5, 8, 0, 0, 0, 0, DateTimeKind.Local), new Guid("85d3f82a-c4c6-42e7-af13-9528218d14fe"), new DateTime(2025, 7, 7, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("864a4954-3779-46f1-b06b-cd40bcefe916"), new Guid("1f197941-ed4c-4cdf-97c2-73de5f27480e"), new DateTime(2025, 5, 3, 0, 0, 0, 0, DateTimeKind.Local), new Guid("85d3f82a-c4c6-42e7-af13-9528218d14fe"), new DateTime(2025, 7, 2, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("8696a621-725d-418a-a9f1-2947e0b68b71"), new Guid("b5d52925-e699-4ee4-986e-f58fc7bfe5e1"), new DateTime(2025, 5, 8, 0, 0, 0, 0, DateTimeKind.Local), new Guid("b12d8bfe-245e-4967-a3f9-8e780c2806e3"), new DateTime(2025, 7, 7, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("8c1b16cb-5810-48a1-81c9-200ecdf0dead"), new Guid("d5859648-78d2-4fb2-b4f3-b2913013d06a"), new DateTime(2025, 5, 12, 0, 0, 0, 0, DateTimeKind.Local), new Guid("85d3f82a-c4c6-42e7-af13-9528218d14fe"), new DateTime(2025, 7, 11, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("9439f8ab-ab23-4fc5-8461-aa026a314f9e"), new Guid("fb98db2a-652d-4a6e-a0b7-cd266a3fabd7"), new DateTime(2025, 4, 30, 0, 0, 0, 0, DateTimeKind.Local), new Guid("b12d8bfe-245e-4967-a3f9-8e780c2806e3"), new DateTime(2025, 6, 29, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("986d8f2b-ad34-4de5-99e8-ed89f14f5aaa"), new Guid("a40a31b4-a136-4313-8a00-753182ba4cbb"), new DateTime(2025, 4, 30, 0, 0, 0, 0, DateTimeKind.Local), new Guid("b12d8bfe-245e-4967-a3f9-8e780c2806e3"), new DateTime(2025, 6, 29, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("99e98e73-1e68-4d85-bcd1-83ea7a06c27b"), new Guid("69ae25c2-269d-4b31-b61d-a3306efdeabe"), new DateTime(2025, 5, 9, 0, 0, 0, 0, DateTimeKind.Local), new Guid("b12d8bfe-245e-4967-a3f9-8e780c2806e3"), new DateTime(2025, 7, 8, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("9e40f2a7-5df0-4530-a53d-82ffde4be843"), new Guid("67dc1965-14f8-4532-b0c4-3a829745e5b7"), new DateTime(2025, 5, 4, 0, 0, 0, 0, DateTimeKind.Local), new Guid("5d31a024-4e84-4f5e-b86b-04b10d79559e"), new DateTime(2025, 7, 3, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("adbbc54b-9430-4192-b797-01fbc231f828"), new Guid("596f5c30-d1de-4ba7-a3ac-67737f83c921"), new DateTime(2025, 5, 4, 0, 0, 0, 0, DateTimeKind.Local), new Guid("5d31a024-4e84-4f5e-b86b-04b10d79559e"), new DateTime(2025, 7, 3, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("cfa34d2f-6bde-4a26-b381-1d076295088e"), new Guid("751ba902-f09f-4f43-9ff1-15cb13597ab2"), new DateTime(2025, 5, 10, 0, 0, 0, 0, DateTimeKind.Local), new Guid("6ef43601-4194-4b07-a2c3-fee8637af4cf"), new DateTime(2025, 7, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("d0851b23-1ca4-4f94-b9c4-218c938c7fc7"), new Guid("7980be9f-489b-4d6a-9ae1-034b41921f7c"), new DateTime(2025, 5, 2, 0, 0, 0, 0, DateTimeKind.Local), new Guid("85d3f82a-c4c6-42e7-af13-9528218d14fe"), new DateTime(2025, 7, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("d479fa4e-a0a1-4268-869b-c818b760c1d9"), new Guid("720b65ab-f427-4d3d-9d06-68d7e31aa07d"), new DateTime(2025, 5, 9, 0, 0, 0, 0, DateTimeKind.Local), new Guid("85d3f82a-c4c6-42e7-af13-9528218d14fe"), new DateTime(2025, 7, 8, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("d753b49b-cf88-44b7-a6c0-6416aa67a780"), new Guid("64131acf-e2d7-4cb0-bc87-ced22c1c4ef0"), new DateTime(2025, 5, 2, 0, 0, 0, 0, DateTimeKind.Local), new Guid("85d3f82a-c4c6-42e7-af13-9528218d14fe"), new DateTime(2025, 7, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("ee186178-6257-48de-9adc-a958701c4a2b"), new Guid("660f8dc9-86b3-46bb-ba0b-e3e5b069d258"), new DateTime(2025, 5, 2, 0, 0, 0, 0, DateTimeKind.Local), new Guid("b12d8bfe-245e-4967-a3f9-8e780c2806e3"), new DateTime(2025, 7, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("f3f9fff2-f565-4588-a4e3-ff7b81882094"), new Guid("f5b74e80-5f91-4206-a81c-bcbb5a630452"), new DateTime(2025, 5, 7, 0, 0, 0, 0, DateTimeKind.Local), new Guid("5d31a024-4e84-4f5e-b86b-04b10d79559e"), new DateTime(2025, 7, 6, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("f8c68237-2726-41a6-aa86-4e3862155c2a"), new Guid("4036633f-fad8-43e7-bacb-83c65c81859f"), new DateTime(2025, 5, 7, 0, 0, 0, 0, DateTimeKind.Local), new Guid("b12d8bfe-245e-4967-a3f9-8e780c2806e3"), new DateTime(2025, 7, 6, 0, 0, 0, 0, DateTimeKind.Local) }
                });
        }
    }
}
