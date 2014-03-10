// ------------------------------------------------------------------------------
// -- Copyright ERTMS Solutions
// -- Licensed under the EUPL V.1.1
// -- http://joinup.ec.europa.eu/software/page/eupl/licence-eupl
// --
// -- This file is part of ERTMSFormalSpec software and documentation
// --
// --  ERTMSFormalSpec is free software: you can redistribute it and/or modify
// --  it under the terms of the EUPL General Public License, v.1.1
// --
// -- ERTMSFormalSpec is distributed in the hope that it will be useful,
// -- but WITHOUT ANY WARRANTY; without even the implied warranty of
// -- MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
// --
// ------------------------------------------------------------------------------
using DataDictionary.Specification;
namespace GUI.SpecificationView
{
    public class RequirementSetsTreeView : TypedTreeView<Paragraph>
    {
        protected override void BuildModel()
        {
            Nodes.Clear();

            foreach (RequirementSetReference reference in Root.RequirementSetReferences)
            {
                Nodes.Add(new RequirementSetReferenceTreeNode(reference, true));
            }
        }
    }
}