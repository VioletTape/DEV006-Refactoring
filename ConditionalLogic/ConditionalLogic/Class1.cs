namespace ConditionalLogic {
    public class Class1 {
        public void MakeBid(int income, int score, bool authorized) {
            if ((score <= 700) &&
                ((income < 40000) || (income > 100000)
                 || !authorized || (score <= 500)) &&
                (income <= 100000)) {
                Reject();
            }
            else {
                Accept();
            }
        }

        private void Reject() {}

        private void Accept() {}
    }

  
}