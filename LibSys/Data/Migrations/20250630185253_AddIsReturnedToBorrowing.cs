using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LibSys.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddIsReturnedToBorrowing : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<bool>(
                name: "IsReturned",
                table: "Borrowings",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f1879ea6-270f-4d04-82dc-4c9f505436d6", "AQAAAAIAAYagAAAAEHpAJ6TmMxA2pwcIzl9m22fnE2GfC2Dq2VPhwTYmgR5qZPeYQC8z3+Oig4V+r3bvJQ==", "c0a5e325-fca3-4bc9-b18a-ea1e05272f79" });

            migrationBuilder.InsertData(
                table: "BookDefinitions",
                columns: new[] { "Id", "Author", "CoverImagePath", "Title" },
                values: new object[,]
                {
                    { new Guid("0e69497b-b805-415b-92b0-44354119c9b8"), "Andrzej Sapkowski", null, "Narrenturm" },
                    { new Guid("1bbb9bc8-3c1b-4eca-9e4b-2b420f3a0d17"), "Stanisław Wyspiański", null, "Wesele" },
                    { new Guid("1c76ea3c-2d75-43db-813a-4c8a6cdf54a6"), "J.K. Rowling", null, "Harry Potter i Książę Półkrwi" },
                    { new Guid("23ea8ae7-34ca-4400-b5a7-9adb729996b9"), "William Shakespeare", null, "Romeo i Julia" },
                    { new Guid("28a5ee12-3dad-4799-a03b-6950dbc839ea"), "Camilla Läckberg", null, "Kamieniarz" },
                    { new Guid("337552a9-c86d-487a-961d-474b1eb70dc3"), "J.K. Rowling", null, "Harry Potter i więzień Azkabanu" },
                    { new Guid("33f65ba7-db1d-4224-8a6a-52be45521301"), "Juliusz Słowacki", null, "Balladyna" },
                    { new Guid("47475748-4707-4e71-9ac2-dbae4d653d34"), "Juliusz Słowacki", null, "Kordian" },
                    { new Guid("492970a0-4063-48a9-bd6c-fef09b2ca85e"), "Camilla Läckberg", null, "Kaznodzieja" },
                    { new Guid("4a5d3b84-7243-4dff-abb2-8c0bec35edf8"), "Camilla Läckberg", null, "Ofiara losu" },
                    { new Guid("57daa9f2-ad3d-4bb3-aaf1-b5009c8b62da"), "Camilla Läckberg", null, "Księżniczka z lodu" },
                    { new Guid("595b559a-418f-42bd-87f7-38fc41e049a3"), "Dan Brown", null, "Inferno" },
                    { new Guid("70e36a70-628f-490c-87b5-e65b0763ca7c"), "Andrzej Ziemiański", null, "Achaja. Tom I" },
                    { new Guid("7cf4fd2a-2085-4898-8ae9-fbba4881d4ad"), "Cassandra Clare", null, "Miasto upadłych aniołów" },
                    { new Guid("83945207-8abc-4fad-979d-d674516ba419"), "George R.R. Martin", null, "Nawałnica mieczy: Stal i śnieg" },
                    { new Guid("85120e11-4dae-45c4-8781-fe61e8e2d0b2"), "Stieg Larsson", null, "Mężczyźni, którzy nienawidzą kobiet" },
                    { new Guid("88e6b985-9172-45ab-8587-392e599177d9"), "J.K. Rowling", null, "Harry Potter i Zakon Feniksa" },
                    { new Guid("948e56f5-2ead-40f2-9588-c80988e20857"), "J.K. Rowling, Jack Thorne", null, "Harry Potter i Przeklęte Dziecko" },
                    { new Guid("97349608-1bfd-4cba-83b5-681872a2b06f"), "Kornel Makuszyński", null, "Szatan z siódmej klasy" },
                    { new Guid("999c84b2-fd5c-42ed-bc77-d77c864197c5"), "Jo Nesbø", null, "Człowiek nietoperz" },
                    { new Guid("aa96bc54-3a60-474f-bd61-8f621de9e036"), "J.K. Rowling", null, "Harry Potter i Komnata Tajemnic" },
                    { new Guid("b2318651-e3d7-4640-8392-0265679afaba"), "Johann Wolfgang von Goethe", null, "Cierpienia młodego Wertera" },
                    { new Guid("bc11f8e7-d772-4a6e-8050-33f8245c86f6"), "Veronica Roth", null, "Niezgodna" },
                    { new Guid("c70a4f54-f758-4221-bc6c-b8a547a4c9d1"), "George R.R. Martin", null, "Starcie królów (edycja ilustrowana)" },
                    { new Guid("de7fce35-50e7-4544-9974-fd0341436ee4"), "Władysław Stanisław Reymont", null, "Chłopi" },
                    { new Guid("e9b23c5c-9fb5-4b5f-bc8e-091a4ad5fab8"), "J.K. Rowling", null, "Harry Potter i Kamień Filozoficzny" },
                    { new Guid("ec1d1cd3-72f1-4b91-b1af-2903e428d101"), "Camilla Läckberg", null, "Niemiecki bękart" },
                    { new Guid("f2321de8-6342-4299-b18b-dedda3150095"), "J.K. Rowling", null, "Harry Potter i Czara Ognia" },
                    { new Guid("f64a0954-bf19-4cac-88bb-2b5222face8f"), "George R.R. Martin", null, "Gra o tron (edycja ilustrowana)" },
                    { new Guid("f6cec10a-12c3-48f0-a849-3e269c980da0"), "Christopher Paolini", null, "Dziedzictwo" }
                });

            migrationBuilder.InsertData(
                table: "Readers",
                columns: new[] { "Id", "City", "Code", "Name", "Street", "UserId" },
                values: new object[,]
                {
                    { new Guid("36e5ee1b-d04d-4a90-ac56-7dd194ac1d3e"), "Poznań", "61-311", "Jan Nowak", "Wieżowa 3", null },
                    { new Guid("d23e27cd-3d26-48ed-b05c-5d2c0ddd2108"), "Poznań", "61-111", "Aleksandra Mechrzycka", "Solna 2", null },
                    { new Guid("f59f0e73-472e-446b-b1bf-c580ff61be61"), "Poznań", "61-111", "Tomasz Rydz", "Garbary 1", null }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "BookDefinitionId", "Comment", "Status" },
                values: new object[,]
                {
                    { new Guid("006cd148-0971-468f-977c-64451fd5ef15"), new Guid("595b559a-418f-42bd-87f7-38fc41e049a3"), null, 0 },
                    { new Guid("0214becb-c144-4208-988b-9c8b86a9a3c1"), new Guid("f64a0954-bf19-4cac-88bb-2b5222face8f"), null, 2 },
                    { new Guid("053cd9e9-e7e2-4478-a5e2-68bb44e79448"), new Guid("4a5d3b84-7243-4dff-abb2-8c0bec35edf8"), null, 2 },
                    { new Guid("0562998d-6691-4089-ae7e-d165ea110cf2"), new Guid("bc11f8e7-d772-4a6e-8050-33f8245c86f6"), null, 2 },
                    { new Guid("0aad2b36-7376-40e5-b2ba-3252ffc6bdb5"), new Guid("28a5ee12-3dad-4799-a03b-6950dbc839ea"), null, 1 },
                    { new Guid("106f6633-4010-41f7-813c-3dcddd78da6f"), new Guid("47475748-4707-4e71-9ac2-dbae4d653d34"), null, 0 },
                    { new Guid("15ea90ad-c058-484a-b998-3f36b356f949"), new Guid("97349608-1bfd-4cba-83b5-681872a2b06f"), null, 0 },
                    { new Guid("181973b6-30bb-474c-9be5-dbd744b62fa9"), new Guid("47475748-4707-4e71-9ac2-dbae4d653d34"), null, 2 },
                    { new Guid("1b4208ee-f302-4aec-be47-1cded755bcfe"), new Guid("23ea8ae7-34ca-4400-b5a7-9adb729996b9"), null, 1 },
                    { new Guid("1c2ac8f7-1d7c-4af3-aad9-034831317d8e"), new Guid("c70a4f54-f758-4221-bc6c-b8a547a4c9d1"), null, 0 },
                    { new Guid("1d3bf77d-cc2d-4b00-aeb5-a4133aa571fd"), new Guid("4a5d3b84-7243-4dff-abb2-8c0bec35edf8"), null, 1 },
                    { new Guid("1e9a251d-969e-4bfc-bc6d-0cf460f76fc2"), new Guid("e9b23c5c-9fb5-4b5f-bc8e-091a4ad5fab8"), null, 0 },
                    { new Guid("2009259f-d93b-4b5b-ac21-75166bd32b95"), new Guid("83945207-8abc-4fad-979d-d674516ba419"), null, 2 },
                    { new Guid("203b70ef-de0a-407b-ba18-da7e682d2c2d"), new Guid("bc11f8e7-d772-4a6e-8050-33f8245c86f6"), null, 0 },
                    { new Guid("2348eb91-6717-41fc-ab21-89377cfc117a"), new Guid("999c84b2-fd5c-42ed-bc77-d77c864197c5"), null, 0 },
                    { new Guid("2533aac5-7ea2-47b4-ae19-fec863eeed56"), new Guid("f6cec10a-12c3-48f0-a849-3e269c980da0"), null, 1 },
                    { new Guid("256c0bf3-b862-4e94-aa8f-67bf39dd8ff8"), new Guid("948e56f5-2ead-40f2-9588-c80988e20857"), null, 0 },
                    { new Guid("28c33ab4-5fb3-482e-8a13-f7ac02df176e"), new Guid("70e36a70-628f-490c-87b5-e65b0763ca7c"), null, 1 },
                    { new Guid("2a9cdd15-429e-4e03-88d7-9cc4d6c3be17"), new Guid("aa96bc54-3a60-474f-bd61-8f621de9e036"), null, 0 },
                    { new Guid("2bfb74eb-46a6-4c85-b8bb-5442209ff626"), new Guid("bc11f8e7-d772-4a6e-8050-33f8245c86f6"), null, 0 },
                    { new Guid("2fa88909-d99e-401a-8cdc-c4980185c574"), new Guid("f2321de8-6342-4299-b18b-dedda3150095"), null, 0 },
                    { new Guid("30549fa6-d062-442e-8282-1b55ae80f494"), new Guid("595b559a-418f-42bd-87f7-38fc41e049a3"), null, 2 },
                    { new Guid("315afc19-6523-4da6-9b21-8663e3da7e1e"), new Guid("47475748-4707-4e71-9ac2-dbae4d653d34"), null, 0 },
                    { new Guid("38c24d1c-cc97-4fa2-8248-72b08869eea2"), new Guid("57daa9f2-ad3d-4bb3-aaf1-b5009c8b62da"), null, 2 },
                    { new Guid("3c036593-c2cd-4d0b-8c24-d452431955ea"), new Guid("97349608-1bfd-4cba-83b5-681872a2b06f"), null, 2 },
                    { new Guid("3c521708-ee34-406c-b506-d8debe3ac454"), new Guid("595b559a-418f-42bd-87f7-38fc41e049a3"), null, 2 },
                    { new Guid("439207bf-35b7-451f-92a0-f1ab477b4d02"), new Guid("88e6b985-9172-45ab-8587-392e599177d9"), null, 1 },
                    { new Guid("44d7b59c-962c-4f3a-b3a2-49c1e44f8d22"), new Guid("aa96bc54-3a60-474f-bd61-8f621de9e036"), null, 0 },
                    { new Guid("4e01c697-29db-4d00-922e-b7ee3879d2fc"), new Guid("33f65ba7-db1d-4224-8a6a-52be45521301"), null, 0 },
                    { new Guid("5088dbc5-216a-4c89-86e4-8c16e1c2b5e6"), new Guid("999c84b2-fd5c-42ed-bc77-d77c864197c5"), null, 0 },
                    { new Guid("52707841-538d-4a4c-9b1c-e3791aa4cdfd"), new Guid("97349608-1bfd-4cba-83b5-681872a2b06f"), null, 1 },
                    { new Guid("553f5fa1-b2ef-476b-b712-483bc6ab0705"), new Guid("97349608-1bfd-4cba-83b5-681872a2b06f"), null, 0 },
                    { new Guid("58b4a1fd-1b16-4ba8-ac2f-a5c8f8a2f581"), new Guid("c70a4f54-f758-4221-bc6c-b8a547a4c9d1"), null, 2 },
                    { new Guid("590121a5-17b2-4b10-af37-4667994a6b15"), new Guid("c70a4f54-f758-4221-bc6c-b8a547a4c9d1"), null, 2 },
                    { new Guid("60800305-01d5-4301-8fbc-b40f3d49db30"), new Guid("97349608-1bfd-4cba-83b5-681872a2b06f"), null, 1 },
                    { new Guid("63ea266c-f76f-4094-91cf-69e3ce705619"), new Guid("948e56f5-2ead-40f2-9588-c80988e20857"), null, 2 },
                    { new Guid("659e3ec2-0d5c-4fa2-b97c-3177efeb1c70"), new Guid("f2321de8-6342-4299-b18b-dedda3150095"), null, 1 },
                    { new Guid("6a8fa858-8e0a-4051-9cb2-497ae4c21214"), new Guid("aa96bc54-3a60-474f-bd61-8f621de9e036"), null, 1 },
                    { new Guid("6bb32d96-3d2d-4bf1-9790-493918d99601"), new Guid("85120e11-4dae-45c4-8781-fe61e8e2d0b2"), null, 1 },
                    { new Guid("6bd5ca91-395e-4045-823c-4afbd0cfee6d"), new Guid("bc11f8e7-d772-4a6e-8050-33f8245c86f6"), null, 2 },
                    { new Guid("6d7b18ec-00ed-4988-8c26-d29bda031173"), new Guid("47475748-4707-4e71-9ac2-dbae4d653d34"), null, 0 },
                    { new Guid("6e327069-29a9-4d23-8322-9026c8e1ad44"), new Guid("70e36a70-628f-490c-87b5-e65b0763ca7c"), null, 2 },
                    { new Guid("6e59d35d-8fd5-4634-807e-8dadfef2a5d7"), new Guid("bc11f8e7-d772-4a6e-8050-33f8245c86f6"), null, 1 },
                    { new Guid("6e6d4afe-0d27-46fb-a426-403ad5820cb1"), new Guid("337552a9-c86d-487a-961d-474b1eb70dc3"), null, 0 },
                    { new Guid("70423068-feb7-4f80-b12c-1f83bf14d00f"), new Guid("ec1d1cd3-72f1-4b91-b1af-2903e428d101"), null, 2 },
                    { new Guid("74c22f15-d275-40f9-b67e-5fc4e3c8a771"), new Guid("c70a4f54-f758-4221-bc6c-b8a547a4c9d1"), null, 2 },
                    { new Guid("769827be-b1a9-4d10-90bd-0c6b0dc30bb7"), new Guid("1bbb9bc8-3c1b-4eca-9e4b-2b420f3a0d17"), null, 0 },
                    { new Guid("7ef3cef9-3982-4bed-a770-0529c4b02964"), new Guid("33f65ba7-db1d-4224-8a6a-52be45521301"), null, 0 },
                    { new Guid("803aec2a-c4fa-4292-9851-2b6cf604c2d3"), new Guid("e9b23c5c-9fb5-4b5f-bc8e-091a4ad5fab8"), null, 0 },
                    { new Guid("824d3b30-4175-46e3-8f6d-8b67e18d3fba"), new Guid("492970a0-4063-48a9-bd6c-fef09b2ca85e"), null, 0 },
                    { new Guid("8251f1ee-8e17-4089-9e51-53e4e2737cad"), new Guid("b2318651-e3d7-4640-8392-0265679afaba"), null, 2 },
                    { new Guid("8633ad5d-9a2a-4d9c-a8ef-2add2bf8acd4"), new Guid("4a5d3b84-7243-4dff-abb2-8c0bec35edf8"), null, 1 },
                    { new Guid("8bc11948-0df4-404a-b484-996a0cc2acdf"), new Guid("ec1d1cd3-72f1-4b91-b1af-2903e428d101"), null, 0 },
                    { new Guid("8e565425-7450-49f9-8b2b-70396b36a687"), new Guid("f64a0954-bf19-4cac-88bb-2b5222face8f"), null, 2 },
                    { new Guid("8f9f276e-6908-4c64-bb6e-d15a8ed38ba9"), new Guid("47475748-4707-4e71-9ac2-dbae4d653d34"), null, 0 },
                    { new Guid("91607397-fd90-4457-97c5-a11a4fd23405"), new Guid("f2321de8-6342-4299-b18b-dedda3150095"), null, 1 },
                    { new Guid("94ea213b-6a1d-46f8-ba49-73cad16af591"), new Guid("ec1d1cd3-72f1-4b91-b1af-2903e428d101"), null, 0 },
                    { new Guid("96e4a1d6-e6d8-4330-9dba-9b62ba6498be"), new Guid("f6cec10a-12c3-48f0-a849-3e269c980da0"), null, 1 },
                    { new Guid("96f9b237-be01-4258-8403-9f987001ec24"), new Guid("88e6b985-9172-45ab-8587-392e599177d9"), null, 1 },
                    { new Guid("983647fe-1ffb-4a36-a85a-8d23f2516175"), new Guid("948e56f5-2ead-40f2-9588-c80988e20857"), null, 2 },
                    { new Guid("9b0ef3d5-6165-4186-ae7a-f0173aff6721"), new Guid("7cf4fd2a-2085-4898-8ae9-fbba4881d4ad"), null, 0 },
                    { new Guid("9dabd019-bfb7-4bf5-b28a-0a6ccc6fb7be"), new Guid("47475748-4707-4e71-9ac2-dbae4d653d34"), null, 1 },
                    { new Guid("a23f23c2-a074-4abc-8f67-7674b29e7ac9"), new Guid("ec1d1cd3-72f1-4b91-b1af-2903e428d101"), null, 2 },
                    { new Guid("a3115a1b-3e96-4a96-9a6b-6d4815b1a0ca"), new Guid("492970a0-4063-48a9-bd6c-fef09b2ca85e"), null, 0 },
                    { new Guid("a887e353-1f8e-4c17-8aba-f60bcec2a7f3"), new Guid("595b559a-418f-42bd-87f7-38fc41e049a3"), null, 1 },
                    { new Guid("ae969c8a-fd02-4707-8542-c2cee3a4a7b3"), new Guid("70e36a70-628f-490c-87b5-e65b0763ca7c"), null, 0 },
                    { new Guid("af0e9bbb-395d-4cc0-8899-0af561a211ca"), new Guid("57daa9f2-ad3d-4bb3-aaf1-b5009c8b62da"), null, 0 },
                    { new Guid("b2b6d315-6a55-427f-824f-faf47ce8e2d9"), new Guid("f64a0954-bf19-4cac-88bb-2b5222face8f"), null, 0 },
                    { new Guid("b9272109-7db1-4302-b70a-8c39efa971b8"), new Guid("7cf4fd2a-2085-4898-8ae9-fbba4881d4ad"), null, 2 },
                    { new Guid("bab8f4da-2feb-4597-b500-2f82046b4372"), new Guid("f6cec10a-12c3-48f0-a849-3e269c980da0"), null, 1 },
                    { new Guid("bf2e055a-70d4-4720-af02-641f6874905d"), new Guid("1bbb9bc8-3c1b-4eca-9e4b-2b420f3a0d17"), null, 2 },
                    { new Guid("c3ae708c-9496-41db-9f83-cc7ff771ef2a"), new Guid("de7fce35-50e7-4544-9974-fd0341436ee4"), null, 1 },
                    { new Guid("c6127225-1e96-4ae1-9637-f33a12d17924"), new Guid("f6cec10a-12c3-48f0-a849-3e269c980da0"), null, 2 },
                    { new Guid("c9284e78-2682-4523-85e3-fe9c66e2f165"), new Guid("97349608-1bfd-4cba-83b5-681872a2b06f"), null, 2 },
                    { new Guid("ca89a60d-dab4-4e6e-bb9b-39c5eb352492"), new Guid("23ea8ae7-34ca-4400-b5a7-9adb729996b9"), null, 2 },
                    { new Guid("cc84facc-cc0c-4ac6-8341-42666bfe5db7"), new Guid("33f65ba7-db1d-4224-8a6a-52be45521301"), null, 0 },
                    { new Guid("cd5a7b63-770e-4ae8-9cf2-1e89cb55cb68"), new Guid("b2318651-e3d7-4640-8392-0265679afaba"), null, 0 },
                    { new Guid("d55e937b-78cd-4285-9a73-a6451744dfc5"), new Guid("ec1d1cd3-72f1-4b91-b1af-2903e428d101"), null, 1 },
                    { new Guid("d677daad-4d65-4f49-8e0d-334e64ecbb7c"), new Guid("999c84b2-fd5c-42ed-bc77-d77c864197c5"), null, 0 },
                    { new Guid("d8894169-882a-4d2e-b9b3-309d80cfd20f"), new Guid("47475748-4707-4e71-9ac2-dbae4d653d34"), null, 2 },
                    { new Guid("db6f2a6e-fa0b-4f24-9d03-59d7e68b3652"), new Guid("948e56f5-2ead-40f2-9588-c80988e20857"), null, 1 },
                    { new Guid("dba7b216-8936-4209-8ba6-60102ae6624a"), new Guid("57daa9f2-ad3d-4bb3-aaf1-b5009c8b62da"), null, 2 },
                    { new Guid("e2e68fd1-fc5a-40b8-89cb-9c295af6f5f5"), new Guid("97349608-1bfd-4cba-83b5-681872a2b06f"), null, 1 },
                    { new Guid("e3559aee-fa6a-42a8-837d-32546d00563a"), new Guid("595b559a-418f-42bd-87f7-38fc41e049a3"), null, 0 },
                    { new Guid("e3cd70c0-e3a8-4812-a2be-f46a751e18d7"), new Guid("47475748-4707-4e71-9ac2-dbae4d653d34"), null, 2 },
                    { new Guid("e6f14bdb-d30a-4f9b-ae5c-7932b025e60d"), new Guid("f64a0954-bf19-4cac-88bb-2b5222face8f"), null, 2 },
                    { new Guid("e6f7f7ae-0034-4e89-84a9-827105ad6b92"), new Guid("4a5d3b84-7243-4dff-abb2-8c0bec35edf8"), null, 1 },
                    { new Guid("eb7621c3-751d-4e0d-9f36-31f66ee069c1"), new Guid("492970a0-4063-48a9-bd6c-fef09b2ca85e"), null, 1 },
                    { new Guid("ebfb3e54-1287-45ad-a7de-3f5f2302bb3d"), new Guid("999c84b2-fd5c-42ed-bc77-d77c864197c5"), null, 2 },
                    { new Guid("ef99b059-84de-485e-bfb9-5de788db41a2"), new Guid("ec1d1cd3-72f1-4b91-b1af-2903e428d101"), null, 1 },
                    { new Guid("f00b5d53-2e3a-4124-9776-92ecf7d3365c"), new Guid("47475748-4707-4e71-9ac2-dbae4d653d34"), null, 0 },
                    { new Guid("f12d90c8-8697-4274-a0bc-2e8273deccf8"), new Guid("999c84b2-fd5c-42ed-bc77-d77c864197c5"), null, 2 },
                    { new Guid("f4fa4a0e-eafb-49fd-97b8-802aa6ddd9ed"), new Guid("70e36a70-628f-490c-87b5-e65b0763ca7c"), null, 0 },
                    { new Guid("f5f41c7d-8936-4482-979f-277d05d1b07c"), new Guid("948e56f5-2ead-40f2-9588-c80988e20857"), null, 2 },
                    { new Guid("fa31f203-3598-4248-8d2b-cc8e818436e0"), new Guid("83945207-8abc-4fad-979d-d674516ba419"), null, 2 },
                    { new Guid("fa444cef-d929-49db-ab26-3f9ba59378ca"), new Guid("83945207-8abc-4fad-979d-d674516ba419"), null, 1 },
                    { new Guid("fa499238-89a6-4307-993d-b661a0fbbeff"), new Guid("de7fce35-50e7-4544-9974-fd0341436ee4"), null, 1 },
                    { new Guid("fb4e2e27-bc59-43ca-90ec-7263caa8d04f"), new Guid("4a5d3b84-7243-4dff-abb2-8c0bec35edf8"), null, 1 },
                    { new Guid("fdef8479-3d17-44f1-a6d6-274292998957"), new Guid("999c84b2-fd5c-42ed-bc77-d77c864197c5"), null, 0 },
                    { new Guid("ff926395-016b-42cb-88b2-f173bbd2a8a0"), new Guid("de7fce35-50e7-4544-9974-fd0341436ee4"), null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Borrowings",
                columns: new[] { "Id", "BookId", "BorrowDate", "IsReturned", "ReaderId", "ReturnDate" },
                values: new object[,]
                {
                    { new Guid("040685b8-8301-49af-9a96-792d0ac5bcbf"), new Guid("9dabd019-bfb7-4bf5-b28a-0a6ccc6fb7be"), new DateTime(2025, 6, 3, 0, 0, 0, 0, DateTimeKind.Local), false, new Guid("36e5ee1b-d04d-4a90-ac56-7dd194ac1d3e"), new DateTime(2025, 8, 2, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("090863c5-a28f-42ab-abcf-54e03140ba0a"), new Guid("db6f2a6e-fa0b-4f24-9d03-59d7e68b3652"), new DateTime(2025, 6, 7, 0, 0, 0, 0, DateTimeKind.Local), false, new Guid("f59f0e73-472e-446b-b1bf-c580ff61be61"), new DateTime(2025, 8, 6, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("0926e9e0-f32e-40cc-9419-8d2471437bb7"), new Guid("bab8f4da-2feb-4597-b500-2f82046b4372"), new DateTime(2025, 6, 9, 0, 0, 0, 0, DateTimeKind.Local), false, new Guid("5d31a024-4e84-4f5e-b86b-04b10d79559e"), new DateTime(2025, 8, 8, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("0a66bd1f-75e1-40d8-9fef-02294a8e52af"), new Guid("c3ae708c-9496-41db-9f83-cc7ff771ef2a"), new DateTime(2025, 6, 2, 0, 0, 0, 0, DateTimeKind.Local), false, new Guid("f59f0e73-472e-446b-b1bf-c580ff61be61"), new DateTime(2025, 8, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("0bd5f8ae-caa7-40e2-84bd-29c6afaf7681"), new Guid("2533aac5-7ea2-47b4-ae19-fec863eeed56"), new DateTime(2025, 6, 7, 0, 0, 0, 0, DateTimeKind.Local), false, new Guid("d23e27cd-3d26-48ed-b05c-5d2c0ddd2108"), new DateTime(2025, 8, 6, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("1b3f7d36-a430-4944-9c9f-d473da2cf48a"), new Guid("ef99b059-84de-485e-bfb9-5de788db41a2"), new DateTime(2025, 6, 2, 0, 0, 0, 0, DateTimeKind.Local), false, new Guid("f59f0e73-472e-446b-b1bf-c580ff61be61"), new DateTime(2025, 8, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("2a4f67db-3f99-4520-9151-66ce0d0118f5"), new Guid("8633ad5d-9a2a-4d9c-a8ef-2add2bf8acd4"), new DateTime(2025, 6, 15, 0, 0, 0, 0, DateTimeKind.Local), false, new Guid("d23e27cd-3d26-48ed-b05c-5d2c0ddd2108"), new DateTime(2025, 8, 14, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("2d886b1f-ca03-4a5e-b72a-ddaffc853c28"), new Guid("a887e353-1f8e-4c17-8aba-f60bcec2a7f3"), new DateTime(2025, 6, 7, 0, 0, 0, 0, DateTimeKind.Local), false, new Guid("d23e27cd-3d26-48ed-b05c-5d2c0ddd2108"), new DateTime(2025, 8, 6, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("385969f0-e7ec-4b38-ae0b-36cdcaa85326"), new Guid("6e59d35d-8fd5-4634-807e-8dadfef2a5d7"), new DateTime(2025, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), false, new Guid("5d31a024-4e84-4f5e-b86b-04b10d79559e"), new DateTime(2025, 8, 10, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("3f634408-4a5e-4536-b288-58ed91d1524b"), new Guid("e2e68fd1-fc5a-40b8-89cb-9c295af6f5f5"), new DateTime(2025, 6, 2, 0, 0, 0, 0, DateTimeKind.Local), false, new Guid("36e5ee1b-d04d-4a90-ac56-7dd194ac1d3e"), new DateTime(2025, 8, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("4b65f7d0-d886-4cb3-90a8-2821d0e60833"), new Guid("6bb32d96-3d2d-4bf1-9790-493918d99601"), new DateTime(2025, 6, 1, 0, 0, 0, 0, DateTimeKind.Local), false, new Guid("f59f0e73-472e-446b-b1bf-c580ff61be61"), new DateTime(2025, 7, 31, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("51805b91-015c-46e7-9f01-074ff00bce8e"), new Guid("96e4a1d6-e6d8-4330-9dba-9b62ba6498be"), new DateTime(2025, 6, 5, 0, 0, 0, 0, DateTimeKind.Local), false, new Guid("36e5ee1b-d04d-4a90-ac56-7dd194ac1d3e"), new DateTime(2025, 8, 4, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("60355a3c-dd53-4941-81e4-b50cb1f5a724"), new Guid("eb7621c3-751d-4e0d-9f36-31f66ee069c1"), new DateTime(2025, 6, 2, 0, 0, 0, 0, DateTimeKind.Local), false, new Guid("d23e27cd-3d26-48ed-b05c-5d2c0ddd2108"), new DateTime(2025, 8, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("6ae226e9-3b14-493c-999d-248d9d6b6f46"), new Guid("91607397-fd90-4457-97c5-a11a4fd23405"), new DateTime(2025, 6, 8, 0, 0, 0, 0, DateTimeKind.Local), false, new Guid("36e5ee1b-d04d-4a90-ac56-7dd194ac1d3e"), new DateTime(2025, 8, 7, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("6ff7f4b2-6642-46bc-91a5-f5174ac46a8f"), new Guid("d55e937b-78cd-4285-9a73-a6451744dfc5"), new DateTime(2025, 6, 9, 0, 0, 0, 0, DateTimeKind.Local), false, new Guid("f59f0e73-472e-446b-b1bf-c580ff61be61"), new DateTime(2025, 8, 8, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("7018558d-0756-41e2-93be-71d3edad42aa"), new Guid("439207bf-35b7-451f-92a0-f1ab477b4d02"), new DateTime(2025, 6, 4, 0, 0, 0, 0, DateTimeKind.Local), false, new Guid("36e5ee1b-d04d-4a90-ac56-7dd194ac1d3e"), new DateTime(2025, 8, 3, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("79d2f1c1-bfe5-4986-af0d-731c076043a6"), new Guid("52707841-538d-4a4c-9b1c-e3791aa4cdfd"), new DateTime(2025, 6, 5, 0, 0, 0, 0, DateTimeKind.Local), false, new Guid("d23e27cd-3d26-48ed-b05c-5d2c0ddd2108"), new DateTime(2025, 8, 4, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("90bcff3d-b740-47f1-80cf-d3a1097332b8"), new Guid("1b4208ee-f302-4aec-be47-1cded755bcfe"), new DateTime(2025, 6, 12, 0, 0, 0, 0, DateTimeKind.Local), false, new Guid("d23e27cd-3d26-48ed-b05c-5d2c0ddd2108"), new DateTime(2025, 8, 11, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("92ba124c-5137-423b-b0f0-b5af1f367967"), new Guid("60800305-01d5-4301-8fbc-b40f3d49db30"), new DateTime(2025, 6, 3, 0, 0, 0, 0, DateTimeKind.Local), false, new Guid("f59f0e73-472e-446b-b1bf-c580ff61be61"), new DateTime(2025, 8, 2, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("99afdec4-babd-4ffc-949e-c273c55ba443"), new Guid("6a8fa858-8e0a-4051-9cb2-497ae4c21214"), new DateTime(2025, 6, 14, 0, 0, 0, 0, DateTimeKind.Local), false, new Guid("d23e27cd-3d26-48ed-b05c-5d2c0ddd2108"), new DateTime(2025, 8, 13, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("a0bc3012-e8e0-4988-b538-74cfe0c635cc"), new Guid("fa444cef-d929-49db-ab26-3f9ba59378ca"), new DateTime(2025, 6, 10, 0, 0, 0, 0, DateTimeKind.Local), false, new Guid("d23e27cd-3d26-48ed-b05c-5d2c0ddd2108"), new DateTime(2025, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("adc6ced8-2902-4e74-aa78-c06428a7aabf"), new Guid("fb4e2e27-bc59-43ca-90ec-7263caa8d04f"), new DateTime(2025, 6, 5, 0, 0, 0, 0, DateTimeKind.Local), false, new Guid("5d31a024-4e84-4f5e-b86b-04b10d79559e"), new DateTime(2025, 8, 4, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("affc8c0e-4313-4bc4-8178-a542387dfacc"), new Guid("28c33ab4-5fb3-482e-8a13-f7ac02df176e"), new DateTime(2025, 6, 15, 0, 0, 0, 0, DateTimeKind.Local), false, new Guid("36e5ee1b-d04d-4a90-ac56-7dd194ac1d3e"), new DateTime(2025, 8, 14, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("b273206b-b049-4648-aaae-73253e7cb0ff"), new Guid("96f9b237-be01-4258-8403-9f987001ec24"), new DateTime(2025, 6, 12, 0, 0, 0, 0, DateTimeKind.Local), false, new Guid("f59f0e73-472e-446b-b1bf-c580ff61be61"), new DateTime(2025, 8, 11, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("c4782b0c-f125-4a58-96a4-1d85424463e7"), new Guid("659e3ec2-0d5c-4fa2-b97c-3177efeb1c70"), new DateTime(2025, 6, 11, 0, 0, 0, 0, DateTimeKind.Local), false, new Guid("d23e27cd-3d26-48ed-b05c-5d2c0ddd2108"), new DateTime(2025, 8, 10, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("c4ab7481-8b9e-4d48-861d-2a92ecbc3f26"), new Guid("0aad2b36-7376-40e5-b2ba-3252ffc6bdb5"), new DateTime(2025, 6, 3, 0, 0, 0, 0, DateTimeKind.Local), false, new Guid("d23e27cd-3d26-48ed-b05c-5d2c0ddd2108"), new DateTime(2025, 8, 2, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("cd7820f7-61b4-43e7-8cd6-ab42ee202591"), new Guid("e6f7f7ae-0034-4e89-84a9-827105ad6b92"), new DateTime(2025, 6, 4, 0, 0, 0, 0, DateTimeKind.Local), false, new Guid("d23e27cd-3d26-48ed-b05c-5d2c0ddd2108"), new DateTime(2025, 8, 3, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("d7db0bc5-4279-47b7-b6b9-94241ec9187f"), new Guid("1d3bf77d-cc2d-4b00-aeb5-a4133aa571fd"), new DateTime(2025, 6, 14, 0, 0, 0, 0, DateTimeKind.Local), false, new Guid("d23e27cd-3d26-48ed-b05c-5d2c0ddd2108"), new DateTime(2025, 8, 13, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("e948689a-0ed5-40bd-ac84-19b244957df4"), new Guid("fa499238-89a6-4307-993d-b661a0fbbeff"), new DateTime(2025, 6, 1, 0, 0, 0, 0, DateTimeKind.Local), false, new Guid("f59f0e73-472e-446b-b1bf-c580ff61be61"), new DateTime(2025, 7, 31, 0, 0, 0, 0, DateTimeKind.Local) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("0e69497b-b805-415b-92b0-44354119c9b8"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("1c76ea3c-2d75-43db-813a-4c8a6cdf54a6"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("006cd148-0971-468f-977c-64451fd5ef15"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0214becb-c144-4208-988b-9c8b86a9a3c1"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("053cd9e9-e7e2-4478-a5e2-68bb44e79448"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0562998d-6691-4089-ae7e-d165ea110cf2"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("106f6633-4010-41f7-813c-3dcddd78da6f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("15ea90ad-c058-484a-b998-3f36b356f949"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("181973b6-30bb-474c-9be5-dbd744b62fa9"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1c2ac8f7-1d7c-4af3-aad9-034831317d8e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1e9a251d-969e-4bfc-bc6d-0cf460f76fc2"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2009259f-d93b-4b5b-ac21-75166bd32b95"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("203b70ef-de0a-407b-ba18-da7e682d2c2d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2348eb91-6717-41fc-ab21-89377cfc117a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("256c0bf3-b862-4e94-aa8f-67bf39dd8ff8"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2a9cdd15-429e-4e03-88d7-9cc4d6c3be17"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2bfb74eb-46a6-4c85-b8bb-5442209ff626"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2fa88909-d99e-401a-8cdc-c4980185c574"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("30549fa6-d062-442e-8282-1b55ae80f494"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("315afc19-6523-4da6-9b21-8663e3da7e1e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("38c24d1c-cc97-4fa2-8248-72b08869eea2"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("3c036593-c2cd-4d0b-8c24-d452431955ea"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("3c521708-ee34-406c-b506-d8debe3ac454"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("44d7b59c-962c-4f3a-b3a2-49c1e44f8d22"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4e01c697-29db-4d00-922e-b7ee3879d2fc"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("5088dbc5-216a-4c89-86e4-8c16e1c2b5e6"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("553f5fa1-b2ef-476b-b712-483bc6ab0705"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("58b4a1fd-1b16-4ba8-ac2f-a5c8f8a2f581"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("590121a5-17b2-4b10-af37-4667994a6b15"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("63ea266c-f76f-4094-91cf-69e3ce705619"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("6bd5ca91-395e-4045-823c-4afbd0cfee6d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("6d7b18ec-00ed-4988-8c26-d29bda031173"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("6e327069-29a9-4d23-8322-9026c8e1ad44"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("6e6d4afe-0d27-46fb-a426-403ad5820cb1"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("70423068-feb7-4f80-b12c-1f83bf14d00f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("74c22f15-d275-40f9-b67e-5fc4e3c8a771"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("769827be-b1a9-4d10-90bd-0c6b0dc30bb7"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("7ef3cef9-3982-4bed-a770-0529c4b02964"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("803aec2a-c4fa-4292-9851-2b6cf604c2d3"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("824d3b30-4175-46e3-8f6d-8b67e18d3fba"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8251f1ee-8e17-4089-9e51-53e4e2737cad"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8bc11948-0df4-404a-b484-996a0cc2acdf"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8e565425-7450-49f9-8b2b-70396b36a687"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8f9f276e-6908-4c64-bb6e-d15a8ed38ba9"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("94ea213b-6a1d-46f8-ba49-73cad16af591"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("983647fe-1ffb-4a36-a85a-8d23f2516175"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9b0ef3d5-6165-4186-ae7a-f0173aff6721"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a23f23c2-a074-4abc-8f67-7674b29e7ac9"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a3115a1b-3e96-4a96-9a6b-6d4815b1a0ca"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ae969c8a-fd02-4707-8542-c2cee3a4a7b3"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("af0e9bbb-395d-4cc0-8899-0af561a211ca"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b2b6d315-6a55-427f-824f-faf47ce8e2d9"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b9272109-7db1-4302-b70a-8c39efa971b8"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("bf2e055a-70d4-4720-af02-641f6874905d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c6127225-1e96-4ae1-9637-f33a12d17924"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c9284e78-2682-4523-85e3-fe9c66e2f165"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ca89a60d-dab4-4e6e-bb9b-39c5eb352492"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("cc84facc-cc0c-4ac6-8341-42666bfe5db7"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("cd5a7b63-770e-4ae8-9cf2-1e89cb55cb68"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d677daad-4d65-4f49-8e0d-334e64ecbb7c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d8894169-882a-4d2e-b9b3-309d80cfd20f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("dba7b216-8936-4209-8ba6-60102ae6624a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e3559aee-fa6a-42a8-837d-32546d00563a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e3cd70c0-e3a8-4812-a2be-f46a751e18d7"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e6f14bdb-d30a-4f9b-ae5c-7932b025e60d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ebfb3e54-1287-45ad-a7de-3f5f2302bb3d"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f00b5d53-2e3a-4124-9776-92ecf7d3365c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f12d90c8-8697-4274-a0bc-2e8273deccf8"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f4fa4a0e-eafb-49fd-97b8-802aa6ddd9ed"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f5f41c7d-8936-4482-979f-277d05d1b07c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("fa31f203-3598-4248-8d2b-cc8e818436e0"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("fdef8479-3d17-44f1-a6d6-274292998957"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ff926395-016b-42cb-88b2-f173bbd2a8a0"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("040685b8-8301-49af-9a96-792d0ac5bcbf"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("090863c5-a28f-42ab-abcf-54e03140ba0a"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("0926e9e0-f32e-40cc-9419-8d2471437bb7"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("0a66bd1f-75e1-40d8-9fef-02294a8e52af"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("0bd5f8ae-caa7-40e2-84bd-29c6afaf7681"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("1b3f7d36-a430-4944-9c9f-d473da2cf48a"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("2a4f67db-3f99-4520-9151-66ce0d0118f5"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("2d886b1f-ca03-4a5e-b72a-ddaffc853c28"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("385969f0-e7ec-4b38-ae0b-36cdcaa85326"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("3f634408-4a5e-4536-b288-58ed91d1524b"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("4b65f7d0-d886-4cb3-90a8-2821d0e60833"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("51805b91-015c-46e7-9f01-074ff00bce8e"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("60355a3c-dd53-4941-81e4-b50cb1f5a724"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("6ae226e9-3b14-493c-999d-248d9d6b6f46"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("6ff7f4b2-6642-46bc-91a5-f5174ac46a8f"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("7018558d-0756-41e2-93be-71d3edad42aa"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("79d2f1c1-bfe5-4986-af0d-731c076043a6"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("90bcff3d-b740-47f1-80cf-d3a1097332b8"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("92ba124c-5137-423b-b0f0-b5af1f367967"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("99afdec4-babd-4ffc-949e-c273c55ba443"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("a0bc3012-e8e0-4988-b538-74cfe0c635cc"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("adc6ced8-2902-4e74-aa78-c06428a7aabf"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("affc8c0e-4313-4bc4-8178-a542387dfacc"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("b273206b-b049-4648-aaae-73253e7cb0ff"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("c4782b0c-f125-4a58-96a4-1d85424463e7"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("c4ab7481-8b9e-4d48-861d-2a92ecbc3f26"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("cd7820f7-61b4-43e7-8cd6-ab42ee202591"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("d7db0bc5-4279-47b7-b6b9-94241ec9187f"));

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: new Guid("e948689a-0ed5-40bd-ac84-19b244957df4"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("1bbb9bc8-3c1b-4eca-9e4b-2b420f3a0d17"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("337552a9-c86d-487a-961d-474b1eb70dc3"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("33f65ba7-db1d-4224-8a6a-52be45521301"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("57daa9f2-ad3d-4bb3-aaf1-b5009c8b62da"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("7cf4fd2a-2085-4898-8ae9-fbba4881d4ad"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("999c84b2-fd5c-42ed-bc77-d77c864197c5"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("b2318651-e3d7-4640-8392-0265679afaba"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("c70a4f54-f758-4221-bc6c-b8a547a4c9d1"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("e9b23c5c-9fb5-4b5f-bc8e-091a4ad5fab8"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("f64a0954-bf19-4cac-88bb-2b5222face8f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0aad2b36-7376-40e5-b2ba-3252ffc6bdb5"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1b4208ee-f302-4aec-be47-1cded755bcfe"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("1d3bf77d-cc2d-4b00-aeb5-a4133aa571fd"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2533aac5-7ea2-47b4-ae19-fec863eeed56"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("28c33ab4-5fb3-482e-8a13-f7ac02df176e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("439207bf-35b7-451f-92a0-f1ab477b4d02"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("52707841-538d-4a4c-9b1c-e3791aa4cdfd"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("60800305-01d5-4301-8fbc-b40f3d49db30"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("659e3ec2-0d5c-4fa2-b97c-3177efeb1c70"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("6a8fa858-8e0a-4051-9cb2-497ae4c21214"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("6bb32d96-3d2d-4bf1-9790-493918d99601"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("6e59d35d-8fd5-4634-807e-8dadfef2a5d7"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8633ad5d-9a2a-4d9c-a8ef-2add2bf8acd4"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("91607397-fd90-4457-97c5-a11a4fd23405"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("96e4a1d6-e6d8-4330-9dba-9b62ba6498be"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("96f9b237-be01-4258-8403-9f987001ec24"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9dabd019-bfb7-4bf5-b28a-0a6ccc6fb7be"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("a887e353-1f8e-4c17-8aba-f60bcec2a7f3"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("bab8f4da-2feb-4597-b500-2f82046b4372"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c3ae708c-9496-41db-9f83-cc7ff771ef2a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d55e937b-78cd-4285-9a73-a6451744dfc5"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("db6f2a6e-fa0b-4f24-9d03-59d7e68b3652"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e2e68fd1-fc5a-40b8-89cb-9c295af6f5f5"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e6f7f7ae-0034-4e89-84a9-827105ad6b92"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("eb7621c3-751d-4e0d-9f36-31f66ee069c1"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ef99b059-84de-485e-bfb9-5de788db41a2"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("fa444cef-d929-49db-ab26-3f9ba59378ca"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("fa499238-89a6-4307-993d-b661a0fbbeff"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("fb4e2e27-bc59-43ca-90ec-7263caa8d04f"));

            migrationBuilder.DeleteData(
                table: "Readers",
                keyColumn: "Id",
                keyValue: new Guid("36e5ee1b-d04d-4a90-ac56-7dd194ac1d3e"));

            migrationBuilder.DeleteData(
                table: "Readers",
                keyColumn: "Id",
                keyValue: new Guid("d23e27cd-3d26-48ed-b05c-5d2c0ddd2108"));

            migrationBuilder.DeleteData(
                table: "Readers",
                keyColumn: "Id",
                keyValue: new Guid("f59f0e73-472e-446b-b1bf-c580ff61be61"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("23ea8ae7-34ca-4400-b5a7-9adb729996b9"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("28a5ee12-3dad-4799-a03b-6950dbc839ea"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("47475748-4707-4e71-9ac2-dbae4d653d34"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("492970a0-4063-48a9-bd6c-fef09b2ca85e"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("4a5d3b84-7243-4dff-abb2-8c0bec35edf8"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("595b559a-418f-42bd-87f7-38fc41e049a3"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("70e36a70-628f-490c-87b5-e65b0763ca7c"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("83945207-8abc-4fad-979d-d674516ba419"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("85120e11-4dae-45c4-8781-fe61e8e2d0b2"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("88e6b985-9172-45ab-8587-392e599177d9"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("948e56f5-2ead-40f2-9588-c80988e20857"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("97349608-1bfd-4cba-83b5-681872a2b06f"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("aa96bc54-3a60-474f-bd61-8f621de9e036"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("bc11f8e7-d772-4a6e-8050-33f8245c86f6"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("de7fce35-50e7-4544-9974-fd0341436ee4"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("ec1d1cd3-72f1-4b91-b1af-2903e428d101"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("f2321de8-6342-4299-b18b-dedda3150095"));

            migrationBuilder.DeleteData(
                table: "BookDefinitions",
                keyColumn: "Id",
                keyValue: new Guid("f6cec10a-12c3-48f0-a849-3e269c980da0"));

            migrationBuilder.DropColumn(
                name: "IsReturned",
                table: "Borrowings");

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
    }
}
