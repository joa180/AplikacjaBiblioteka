using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LibSys.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddIdentityRoleSupport : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Readers",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6413944e-a5d8-430e-9a85-a914f5cb349b", null, "User", "USER" },
                    { "8398a233-f6b9-4361-977c-da6a3e9c2bbe", null, "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3dc9ebbc-5922-4be0-a806-db5d353b2e68", "ADMIN@GMAIL.COM", "AQAAAAIAAYagAAAAEPjPmy8yb6w+Bgexl67VP5CITdKaaGr+P0eU5kQHHiiqbQmVWhHkg05Zy61WNHE5pA==", "92c3ef5c-53bd-4d53-abd7-a222c777bc07" });

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

            migrationBuilder.UpdateData(
                table: "Readers",
                keyColumn: "Id",
                keyValue: new Guid("5d31a024-4e84-4f5e-b86b-04b10d79559e"),
                column: "UserId",
                value: null);

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
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "8398a233-f6b9-4361-977c-da6a3e9c2bbe", "b74ddd14-6340-4840-95c2-db12554843e5" });

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

            migrationBuilder.CreateIndex(
                name: "IX_Readers_UserId",
                table: "Readers",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Readers_AspNetUsers_UserId",
                table: "Readers",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Readers_AspNetUsers_UserId",
                table: "Readers");

            migrationBuilder.DropIndex(
                name: "IX_Readers_UserId",
                table: "Readers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6413944e-a5d8-430e-9a85-a914f5cb349b");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8398a233-f6b9-4361-977c-da6a3e9c2bbe", "b74ddd14-6340-4840-95c2-db12554843e5" });

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
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8398a233-f6b9-4361-977c-da6a3e9c2bbe");

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

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Readers");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fa78fc55-4db8-4dac-80ab-61d95afedcd1", null, "AQAAAAIAAYagAAAAEMx7VebQWX0LbidKwWNUuxcQTk1yTTh/7OiKgSgL7O7taZjV3HVCqYi+TWIxJRdiuQ==", "1fb975c5-9801-411c-aa2a-fab067a2775b" });

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
    }
}
