using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VfpClient.Tests.Schema {
    [TestClass]
    public class ProcedureParameterSchemaProviderTests : TestBase {
        [TestMethod]
        public void ProcedureParameterSchemaProviderTests_GetSchemaWithProcedureNameReferentialIntegrityTest() {
            using (var connection = GetConnection()) {
                var actual = connection.GetSchema(VfpConnection.SchemaNames.ProcedureParameters, new[] { "riupdate", "true" });
                var expected = ProcedureParameterSchemaProviderExpected.GetSchemaWithProcedureNameReferentialIntegrity();

                //DataTableHelper.WriteDataTableCode("SchemaWithProcedureNameReferentialIntegrity", actual);
                DataTableHelper.AssertDataTablesAreEqual(expected, actual);
            }
        }

        [TestMethod]
        public void ProcedureParameterSchemaProviderTests_GetSchemaWithReferentialIntegrityTest() {
            using (var connection = GetConnection()) {
                var actual = connection.GetSchema(VfpConnection.SchemaNames.ProcedureParameters, new[] { null, "true" });
                var expected = ProcedureParameterSchemaProviderExpected.GetSchemaWithReferentialIntegrity();

                //DataTableHelper.WriteDataTableCode("SchemaWithReferentialIntegrity", actual);
                DataTableHelper.AssertDataTablesAreEqual(expected, actual);
            }
        }

        [TestMethod]
        public void ProcedureParameterSchemaProviderTests_GetSchemaWithProcedureNameTest() {
            using (var connection = GetConnection()) {
                var actual = connection.GetSchema(VfpConnection.SchemaNames.ProcedureParameters, new[] { "custorderhist" });
                var expected = ProcedureParameterSchemaProviderExpected.GetSchemaWithProcedureName();

                //DataTableHelper.WriteDataTableCode("SchemaWithProcedureName", actual);
                DataTableHelper.AssertDataTablesAreEqual(expected, actual);
            }
        }

        [TestMethod]
        public void ProcedureParameterSchemaProviderTests_GetSchemaTest() {
            using (var connection = GetConnection()) {
                var actual = connection.GetSchema(VfpConnection.SchemaNames.ProcedureParameters);
                var expected = ProcedureParameterSchemaProviderExpected.GetSchema();

                //DataTableHelper.WriteDataTableCode("Schema", actual);
                DataTableHelper.AssertDataTablesAreEqual(expected, actual);
            }
        }
    }
}