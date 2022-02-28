using System.Collections.Generic;

namespace NPF_MultiplesOfEleven.Contracts
{
    public class Result
    {
        public string Number { get; set; }
        public bool IsMultiple { get; set; }
    }

    public class MultipleOfElevenOutputData
    {
        public List<Result> Result { get; set; }
    }
}
