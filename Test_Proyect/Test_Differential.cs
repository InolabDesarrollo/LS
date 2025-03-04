using ParticleReader.Responsabilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Test_Proyect
{
    
    public class Test_Differential
    {

        [Fact]
        public void testFillDifferentialRunOne()
        {
            //Arrange
            DataTable differentialValues = new DataTable();
            DataTable accumulatedValues = new DataTable();
            accumulatedValues = this.fillDataTableTest();
            Differential differential = new Differential(accumulatedValues);

            //Action 
            differentialValues = differential.fillDifferentialValuesRunOne();
            double valueTest = Convert.ToDouble(differentialValues.Rows[2][1].ToString());
            double rigthValue = 5.75;

            //Asser
            Assert.Equal(rigthValue, valueTest);
        }

        [Fact]
        public void testFillDifferentialRunTwo()
        {
            //Arrange
            DataTable Differential = this.fillDataTableTestRunTwo();
            DataTable accumulatedValues = new DataTable();
            accumulatedValues = this.fillDataTableTest();
            Differential differential = new Differential(accumulatedValues);

            //Action 
            DataTable differentialValuesRunTwo = differential.fillDifferentialValuesRunTwo(Differential);
            double valueTest = Convert.ToDouble(differentialValuesRunTwo.Rows[2][2].ToString());
            double rigthValue = 5.54;

            //Asser
            Assert.Equal(rigthValue, valueTest);
        }

        [Fact]
        public void testFillDifferentialRunThree()
        {
            //Arrange
            DataTable differentialValues = this.fillDataTableTestRunThree();
            differentialValues.Columns.Add("Differential Run 3");

            DataTable accumulatedValues = this.fillDataTableTest();
            Differential differential = new Differential(accumulatedValues);

            //Action 
            DataTable differentialValuesRunThree = differential.fillDifferentialValuesRunThree(differentialValues);
            double valueTest = Convert.ToDouble(differentialValuesRunThree.Rows[2]["Differential Run 3"].ToString());
            double rigthValue = 5.59;

            //Asser
            Assert.Equal(rigthValue, valueTest);
        }

        [Fact]
        public void testFillDifferential()
        {
            //Arrange
            DataTable cumulativeValues = this.fillDataTableTest();
            Differential differential = new Differential(cumulativeValues);
            DataTable differentialValues = differential.getDifferentialTable();

            //Action 
            double value = Convert.ToDouble(differentialValues.Rows[2]["Differential Run 2"].ToString());
            double expectValue = 5.54;

            //Assert
            Assert.Equal(expectValue, value);
        }

        private DataTable fillDataTableTest()
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Particle Size (micron)", typeof(int));
            dataTable.Columns.Add("Mesh", typeof(int));
            dataTable.Columns.Add("Run_1 Cumulatives <", typeof(double));
            dataTable.Columns.Add("Run_2 Cumulatives <", typeof(double));
            dataTable.Columns.Add("Run_3 Cumulatives <", typeof(double));

            dataTable.Columns.Add("Run_1 Cumulatives >", typeof(double));
            dataTable.Columns.Add("Run_2 Cumulatives >", typeof(double));
            dataTable.Columns.Add("Run_3 Cumulatives >", typeof(double));

            dataTable.Rows.Add(0,  999,   0,    0,     0,       0,      0,       0);
            dataTable.Rows.Add(29, 635, 74.7,  72.67, 74.1, 25.3,   27.33,    25.9);
            dataTable.Rows.Add(34, 500, 79.27,  77,   78.5, 20.73,     23,    21.5);
            dataTable.Rows.Add(42, 450, 85.02, 82.54, 84.09, 14.98, 17.46,    15.91);
            return dataTable;
        }

        private DataTable fillDataTableTestRunTwo()
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Mesh", typeof(int));
            dataTable.Columns.Add("Differential Run 1", typeof(double));
            dataTable.Columns.Add("Differential Run 2", typeof(double));

            dataTable.Rows.Add(999, 74.7);
            dataTable.Rows.Add(635, 4.57);
            dataTable.Rows.Add(500, 5.75);
            dataTable.Rows.Add(450, 14.97);
            return dataTable;
        }

        private DataTable fillDataTableTestRunThree()
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Mesh", typeof(int));
            dataTable.Columns.Add("DifferentialValues Run 1", typeof(double));
            dataTable.Columns.Add("DifferentialValues Run 2", typeof(double));

            dataTable.Rows.Add(999, 74.7, 72.67);
            dataTable.Rows.Add(635, 4.57, 4.33);
            dataTable.Rows.Add(500, 5.75, 5.54);
            dataTable.Rows.Add(450, 14.97, 17.46);
            return dataTable;
        }
    }
}
