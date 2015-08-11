﻿namespace QckQuery
{
    using QckQuery.Exceptions.Querying;
    using QckQuery.Formatting;

    public partial class QuickQuery
    {
        /// <summary>
        /// Runs the given query giving no return.
        /// Throws UnexpectedNumberOfRowsAffected if the number of affected rows is different from N.
        /// It uses DbCommand.ExecuteNonQuery underneath.
        /// </summary>
        /// <param name="n">Number of affected rows to ensure</param>
        /// <param name="sql">Query to run</param>
        /// <param name="parameters">Parameters names and values pairs</param>
        /// <exception cref="UnexpectedNumberOfRowsAffected">
        /// If the number of affected rows is different from N
        /// </exception>
        public void ChangeExactly(int n, string sql, object parameters)
        {
            WithoutReturn(n, sql, false, DictionaryMaker.Make(parameters));
        }

        /// <summary>
        /// Runs the given query giving no return.
        /// Throws UnexpectedNumberOfRowsAffected if the number of affected rows is different from N.
        /// It uses DbCommand.ExecuteNonQuery underneath.
        /// </summary>
        /// <param name="n">Number of affected rows to ensure</param>
        /// <param name="sql">Query to run</param>
        /// <param name="parameters">Parameters names and values pairs</param>
        /// <exception cref="UnexpectedNumberOfRowsAffected">
        /// If the number of affected rows is different from N
        /// </exception>
        public void ChangeExactly(int n, string sql, params object[] parameters)
        {
            WithoutReturn(n, sql, false, DictionaryMaker.Make(parameters));
        }
    }
}