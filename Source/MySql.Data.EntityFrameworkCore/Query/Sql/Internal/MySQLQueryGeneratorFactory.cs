﻿// Copyright © 2015, 2016 Oracle and/or its affiliates. All rights reserved.
//
// MySQL Connector/NET is licensed under the terms of the GPLv2
// <http://www.gnu.org/licenses/old-licenses/gpl-2.0.html>, like most 
// MySQL Connectors. There are special exceptions to the terms and 
// conditions of the GPLv2 as it is applied to this software, see the 
// FLOSS License Exception
// <http://www.mysql.com/about/legal/licensing/foss-exception.html>.
//
// This program is free software; you can redistribute it and/or modify 
// it under the terms of the GNU General Public License as published 
// by the Free Software Foundation; version 2 of the License.
//
// This program is distributed in the hope that it will be useful, but 
// WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY 
// or FITNESS FOR A PARTICULAR PURPOSE. See the GNU General Public License 
// for more details.
//
// You should have received a copy of the GNU General Public License along 
// with this program; if not, write to the Free Software Foundation, Inc., 
// 51 Franklin St, Fifth Floor, Boston, MA 02110-1301  USA

using System;
using Microsoft.EntityFrameworkCore.Query.Expressions;
using Microsoft.EntityFrameworkCore.Query.Sql;
using Microsoft.EntityFrameworkCore.Storage;

namespace MySQL.Data.EntityFrameworkCore.Query
{
  /// <summary>
  /// Implementation for QuerySqlGeneratorFactoryBase
  /// </summary>
  public class MySQLQueryGeneratorFactory : QuerySqlGeneratorFactoryBase
  {
    //private readonly IRelationalCommandBuilderFactory _commandBuilderFactory;
    //private readonly ISqlGenerationHelper _sqlGenerationHelper;
    //private readonly IParameterNameGeneratorFactory _parameterNameGeneratorFactory;
    //private readonly IRelationalTypeMapper _relationalTypeMapper;

    public MySQLQueryGeneratorFactory(IRelationalCommandBuilderFactory commandBuilderFactory,
            ISqlGenerationHelper sqlGenerationHelper,
            IParameterNameGeneratorFactory parameterNameGeneratorFactory,
            IRelationalTypeMapper relationalTypeMapper)
            : base(
               commandBuilderFactory,
               sqlGenerationHelper, 
               parameterNameGeneratorFactory,
               relationalTypeMapper)
    {     
    }


    public override IQuerySqlGenerator CreateDefault(SelectExpression selectExpression)
        => new MySQLQuerySqlGenerator(
            CommandBuilderFactory,
            SqlGenerationHelper,
            ParameterNameGeneratorFactory,
            RelationalTypeMapper,
            selectExpression);
  

  //public ISqlQueryGenerator CreateGenerator(SelectExpression selectExpression)
  //{
  //  ThrowIf.Argument.IsNull(selectExpression, nameof(selectExpression));
  //  return new MySQLQuerySqlGenerator(_relationalCommandBuilderFactory, _sqlGenerator, _parameterNameGeneratorFactory, selectExpression);
  //}

  //public ISqlQueryGenerator CreateRawCommandGenerator(SelectExpression selectExpression, string sql, object[] parameters)
  //{
  //  throw new NotImplementedException();
  //}
  }
}