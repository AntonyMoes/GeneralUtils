﻿using System;

namespace GeneralUtils.States {
    public abstract class StateWithInfo<TStateEnum, TStateInfo> : AbstractState<TStateEnum>
        where TStateEnum : struct, Enum
        where TStateInfo : StateInfo  {
        public sealed override void OnStateEnter(StateInfo stateInfo = null) {
            PerformStateEnter(stateInfo as TStateInfo);
        }

        protected virtual void PerformStateEnter(TStateInfo stateInfo = null) { }
    }
}
