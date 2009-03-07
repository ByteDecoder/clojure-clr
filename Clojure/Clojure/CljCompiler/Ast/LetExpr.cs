﻿/**
 *   Copyright (c) David Miller. All rights reserved.
 *   The use and distribution terms for this software are covered by the
 *   Eclipse Public License 1.0 (http://opensource.org/licenses/eclipse-1.0.php)
 *   which can be found in the file epl-v10.html at the root of this distribution.
 *   By using this software in any fashion, you are agreeing to be bound by
 * 	 the terms of this license.
 *   You must not remove this notice, or any other, from this software.
 **/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clojure.lang.CljCompiler.Ast
{
    class LetExpr : Expr
    {
        #region Data

        readonly PersistentVector _bindingInits;
        readonly Expr _body;
        readonly bool _isLoop;

        #endregion

        #region Ctors

        public LetExpr(PersistentVector bindingInits, Expr body, bool isLoop)
        {
            _bindingInits = bindingInits;
            _body = body;
            _isLoop = isLoop;
        }

        #endregion

        #region Type mangling

        public override bool HasClrType
        {
            get { return _body.HasClrType; }
        }

        public override Type ClrType
        {
            get { return _body.ClrType; }
        }

        #endregion

        public sealed class Parser : IParser
        {
            public Expr Parse(object form)
            {
                throw new NotImplementedException();
            }
        }
    }
}
