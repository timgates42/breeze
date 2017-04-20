 
namespace Proto4z  
{ 
 
    public class DictProp: Proto4z.IProtoObject //战斗属性  
    {     
        //proto id   
        public const ushort protoID = 11000;  
        static public ushort getProtoID() { return 11000; } 
        static public string getProtoName() { return "DictProp"; } 
        //members   
        public ulong id;  
        public double hp; //血量值  
        public double attack; //伤害  
        public double moveSpeed; //移动速度  
        public double attackSpeed; //攻击速度  
        public string desc;  
        public DictProp()  
        { 
            id = 0;  
            hp = 0.0;  
            attack = 0.0;  
            moveSpeed = 0.0;  
            attackSpeed = 0.0;  
            desc = "";  
        } 
        public DictProp(ulong id, double hp, double attack, double moveSpeed, double attackSpeed, string desc) 
        { 
            this.id = id; 
            this.hp = hp; 
            this.attack = attack; 
            this.moveSpeed = moveSpeed; 
            this.attackSpeed = attackSpeed; 
            this.desc = desc; 
        } 
        public System.Collections.Generic.List<byte> __encode() 
        { 
            var data = new System.Collections.Generic.List<byte>(); 
            data.AddRange(Proto4z.BaseProtoObject.encodeUI64(this.id)); 
            data.AddRange(Proto4z.BaseProtoObject.encodeDouble(this.hp)); 
            data.AddRange(Proto4z.BaseProtoObject.encodeDouble(this.attack)); 
            data.AddRange(Proto4z.BaseProtoObject.encodeDouble(this.moveSpeed)); 
            data.AddRange(Proto4z.BaseProtoObject.encodeDouble(this.attackSpeed)); 
            data.AddRange(Proto4z.BaseProtoObject.encodeString(this.desc)); 
            return data; 
        } 
        public int __decode(byte[] binData, ref int pos) 
        { 
            this.id = Proto4z.BaseProtoObject.decodeUI64(binData, ref pos); 
            this.hp = Proto4z.BaseProtoObject.decodeDouble(binData, ref pos); 
            this.attack = Proto4z.BaseProtoObject.decodeDouble(binData, ref pos); 
            this.moveSpeed = Proto4z.BaseProtoObject.decodeDouble(binData, ref pos); 
            this.attackSpeed = Proto4z.BaseProtoObject.decodeDouble(binData, ref pos); 
            this.desc = Proto4z.BaseProtoObject.decodeString(binData, ref pos); 
            return pos; 
        } 
    } 
 
 
    public class DictPropArray : System.Collections.Generic.List<DictProp>, Proto4z.IProtoObject  
    { 
        public System.Collections.Generic.List<byte> __encode() 
        { 
            var ret = new System.Collections.Generic.List<byte>(); 
            int len = (int)this.Count; 
            ret.AddRange(Proto4z.BaseProtoObject.encodeI32(len)); 
            for (int i = 0; i < this.Count; i++ ) 
            { 
                ret.AddRange(this[i].__encode()); 
            } 
            return ret; 
        } 
 
        public int __decode(byte[] binData, ref int pos) 
        { 
            int len = Proto4z.BaseProtoObject.decodeI32(binData, ref pos); 
            if(len > 0) 
            { 
                for (int i=0; i<len; i++) 
                { 
                    var data = new DictProp(); 
                    data.__decode(binData, ref pos); 
                    this.Add(data); 
                } 
            } 
            return pos; 
        } 
    } 
 
 
    public class DictPropMap : System.Collections.Generic.Dictionary<ulong, DictProp>, Proto4z.IProtoObject  
    { 
        public System.Collections.Generic.List<byte> __encode() 
        { 
            var ret = new System.Collections.Generic.List<byte>(); 
            int len = (int)this.Count; 
            ret.AddRange(Proto4z.BaseProtoObject.encodeI32(len)); 
            foreach(var kv in this) 
            { 
                ret.AddRange(Proto4z.BaseProtoObject.encodeUI64(kv.Key)); 
                ret.AddRange(kv.Value.__encode()); 
            } 
            return ret; 
        } 
 
        public int __decode(byte[] binData, ref int pos) 
        { 
            int len = Proto4z.BaseProtoObject.decodeI32(binData, ref pos); 
            if(len > 0) 
            { 
                for (int i=0; i<len; i++) 
                { 
                    var key = Proto4z.BaseProtoObject.decodeUI64(binData, ref pos); 
                    var val = new DictProp(); 
                    val.__decode(binData, ref pos); 
                    this.Add(key, val); 
                } 
            } 
            return pos; 
        } 
    } 
 
    public class AOESearch: Proto4z.IProtoObject 
    {     
        //proto id   
        public const ushort protoID = 11003;  
        static public ushort getProtoID() { return 11003; } 
        static public string getProtoName() { return "AOESearch"; } 
        //members   
        public ulong id;  
        public ushort etype; //实体类型, 玩家/AI 或者是NONE忽略该选项  
        public ulong camp; //0忽略阵营, 1自己, 2同阵营非自己, 3敌方,  4中立  
        public string campText;  
        public ushort isRect; //0扇形, 其他矩形  
        public double distance; //伤害距离  
        public double radian; //弧度或者宽度  
        public double offsetX; //坐标偏移量, 以caster为原点, 朝向为y轴  
        public double offsetY; //坐标偏移量, 以caster为原点, 朝向为y轴  
        public ulong limitEntitys; //最大目标数, 距离优先  
        public AOESearch()  
        { 
            id = 0;  
            etype = 0;  
            camp = 0;  
            campText = "";  
            isRect = 0;  
            distance = 0.0;  
            radian = 0.0;  
            offsetX = 0.0;  
            offsetY = 0.0;  
            limitEntitys = 0;  
        } 
        public AOESearch(ulong id, ushort etype, ulong camp, string campText, ushort isRect, double distance, double radian, double offsetX, double offsetY, ulong limitEntitys) 
        { 
            this.id = id; 
            this.etype = etype; 
            this.camp = camp; 
            this.campText = campText; 
            this.isRect = isRect; 
            this.distance = distance; 
            this.radian = radian; 
            this.offsetX = offsetX; 
            this.offsetY = offsetY; 
            this.limitEntitys = limitEntitys; 
        } 
        public System.Collections.Generic.List<byte> __encode() 
        { 
            var data = new System.Collections.Generic.List<byte>(); 
            data.AddRange(Proto4z.BaseProtoObject.encodeUI64(this.id)); 
            data.AddRange(Proto4z.BaseProtoObject.encodeUI16(this.etype)); 
            data.AddRange(Proto4z.BaseProtoObject.encodeUI64(this.camp)); 
            data.AddRange(Proto4z.BaseProtoObject.encodeString(this.campText)); 
            data.AddRange(Proto4z.BaseProtoObject.encodeUI16(this.isRect)); 
            data.AddRange(Proto4z.BaseProtoObject.encodeDouble(this.distance)); 
            data.AddRange(Proto4z.BaseProtoObject.encodeDouble(this.radian)); 
            data.AddRange(Proto4z.BaseProtoObject.encodeDouble(this.offsetX)); 
            data.AddRange(Proto4z.BaseProtoObject.encodeDouble(this.offsetY)); 
            data.AddRange(Proto4z.BaseProtoObject.encodeUI64(this.limitEntitys)); 
            return data; 
        } 
        public int __decode(byte[] binData, ref int pos) 
        { 
            this.id = Proto4z.BaseProtoObject.decodeUI64(binData, ref pos); 
            this.etype = Proto4z.BaseProtoObject.decodeUI16(binData, ref pos); 
            this.camp = Proto4z.BaseProtoObject.decodeUI64(binData, ref pos); 
            this.campText = Proto4z.BaseProtoObject.decodeString(binData, ref pos); 
            this.isRect = Proto4z.BaseProtoObject.decodeUI16(binData, ref pos); 
            this.distance = Proto4z.BaseProtoObject.decodeDouble(binData, ref pos); 
            this.radian = Proto4z.BaseProtoObject.decodeDouble(binData, ref pos); 
            this.offsetX = Proto4z.BaseProtoObject.decodeDouble(binData, ref pos); 
            this.offsetY = Proto4z.BaseProtoObject.decodeDouble(binData, ref pos); 
            this.limitEntitys = Proto4z.BaseProtoObject.decodeUI64(binData, ref pos); 
            return pos; 
        } 
    } 
 
    public enum SKILL_TRIGGER_STAMP : ulong 
    { 
        SKILL_TRIGGER_WHEN_LOAD_BUFF = 5, //加载buff立刻触发  
        SKILL_TRIGGER_WHEN_UNLOAD_BUFF = 6, //卸载buff立刻触发  
        SKILL_TRIGGER_PRE_DEATH = 10, //死亡前触发  
        SKILL_TRIGGER_AFT_DEATH = 11, //死亡后触发  
        SKILL_TRIGGER_WHEN_GENERAL = 15, //攻击触发  
        SKILL_TRIGGER_WHEN_PHYSICAL = 16, //攻击触发  
        SKILL_TRIGGER_WHEN_MAGIC = 17, //攻击触发  
        SKILL_TRIGGER_ON_GENERAL = 20, //被攻击触发  
        SKILL_TRIGGER_ON_PHYSICAL = 21, //被攻击触发  
        SKILL_TRIGGER_ON_MAGIC = 22, //被攻击触发  
        SKILL_TRIGGER_WHEN_ATTACH_GENERAL = 30, //攻击触发  
        SKILL_TRIGGER_WHEN_ON_ATTACH = 31, //被攻击触发  
    }; 
 
    public enum BUFF_STAMP : ulong 
    { 
        BUFF_HALO = 1, //描述性类型: 光环  
        BUFF_BUFF = 2, //描述性类型: 增益buff  
        BUFF_DEBUFF = 3, //描述性类型: 减益BUFF  
        BUFF_HIDE = 4, //描述性类型: 客户端不表现  
        BUFF_PASSIVE = 5, //描述性类型: 被动技能, 无法永久存在, 但死亡会停止任何触发  
        BUFF_HOLD_MOVE = 10, //控制: 禁止移动  
        BUFF_REVERSE_MOVE = 11, //控制: 移动反向  
        BUFF_SILENCE_GENERAL = 12, //控制: 沉默普攻  
        BUFF_SILENCE_PHYSICAL = 13, //控制: 沉默物攻  
        BUFF_SILENCE_MAGIC = 14, //控制: 沉默法攻  
        BUFF_IMMUNE_MOVE = 20, //免疫: 免疫移动类控制  
        BUFF_IMMUNE_SILENCE_GENERAL = 21, //免疫: 免疫普攻沉默  
        BUFF_IMMUNE_SILENCE_PHYSICAL = 22, //免疫: 免疫物攻沉默  
        BUFF_IMMUNE_SILENCE_MAGIC = 23, //免疫: 免疫法攻沉默  
        BUFF_IMMUNE_DEBUFF = 30, //免疫: 免疫DEBUFF  
        BUFF_IMMUNE_BUFF = 31, //免疫: 免疫增益BUFF  
        BUFF_IMMUNE_OCCUPIED = 32, //免疫: 免疫占据  
        BUFF_IMMUNE_FLOAT = 33, //免疫: 免疫击飞  
        BUFF_IMMUNE_MOVEBACK = 34, //免疫: 免疫击退  
        BUFF_IMMUNE_BREAK = 35, //免疫: 免疫技能中断  
    }; 
 
    public class DictBuffEffect: Proto4z.IProtoObject 
    {     
        //proto id   
        public const ushort protoID = 11004;  
        static public ushort getProtoID() { return 11004; } 
        static public string getProtoName() { return "DictBuffEffect"; } 
        //members   
        public ulong id;  
        public ulong listenTriggerStamp;  
        public string listenTriggerStampText;  
        public ulong propID; //提升的属性效果, 求积方式的参数是基础属性 不算其他装备  
        public DictArrayKey skills; //触发技能  
        public string skillsText; //触发技能 格式id,id,id   
        public DictArrayKey buffs; //触发buff  
        public string buffsText; //触发buff 格式id,id,id  
        public double areaTrigger; //距离触发, 0为无效  
        public double timerTrigger; //定时器触发间隔  
        public double intervalLimit; //最小触发间隔时间, 0为无效  
        public double triggerCountLimit; //触发次数限制  
        public double autoUnloadBuff; //超出触发次数后自动移除buff  
        public string desc;  
        public DictBuffEffect()  
        { 
            id = 0;  
            listenTriggerStamp = 0;  
            listenTriggerStampText = "";  
            propID = 0;  
            skills = new DictArrayKey();  
            skillsText = "";  
            buffs = new DictArrayKey();  
            buffsText = "";  
            areaTrigger = 0.0;  
            timerTrigger = 0.0;  
            intervalLimit = 0.0;  
            triggerCountLimit = 0.0;  
            autoUnloadBuff = 0.0;  
            desc = "";  
        } 
        public DictBuffEffect(ulong id, ulong listenTriggerStamp, string listenTriggerStampText, ulong propID, DictArrayKey skills, string skillsText, DictArrayKey buffs, string buffsText, double areaTrigger, double timerTrigger, double intervalLimit, double triggerCountLimit, double autoUnloadBuff, string desc) 
        { 
            this.id = id; 
            this.listenTriggerStamp = listenTriggerStamp; 
            this.listenTriggerStampText = listenTriggerStampText; 
            this.propID = propID; 
            this.skills = skills; 
            this.skillsText = skillsText; 
            this.buffs = buffs; 
            this.buffsText = buffsText; 
            this.areaTrigger = areaTrigger; 
            this.timerTrigger = timerTrigger; 
            this.intervalLimit = intervalLimit; 
            this.triggerCountLimit = triggerCountLimit; 
            this.autoUnloadBuff = autoUnloadBuff; 
            this.desc = desc; 
        } 
        public System.Collections.Generic.List<byte> __encode() 
        { 
            var data = new System.Collections.Generic.List<byte>(); 
            data.AddRange(Proto4z.BaseProtoObject.encodeUI64(this.id)); 
            data.AddRange(Proto4z.BaseProtoObject.encodeUI64(this.listenTriggerStamp)); 
            data.AddRange(Proto4z.BaseProtoObject.encodeString(this.listenTriggerStampText)); 
            data.AddRange(Proto4z.BaseProtoObject.encodeUI64(this.propID)); 
            if (this.skills == null) this.skills = new DictArrayKey(); 
            data.AddRange(this.skills.__encode()); 
            data.AddRange(Proto4z.BaseProtoObject.encodeString(this.skillsText)); 
            if (this.buffs == null) this.buffs = new DictArrayKey(); 
            data.AddRange(this.buffs.__encode()); 
            data.AddRange(Proto4z.BaseProtoObject.encodeString(this.buffsText)); 
            data.AddRange(Proto4z.BaseProtoObject.encodeDouble(this.areaTrigger)); 
            data.AddRange(Proto4z.BaseProtoObject.encodeDouble(this.timerTrigger)); 
            data.AddRange(Proto4z.BaseProtoObject.encodeDouble(this.intervalLimit)); 
            data.AddRange(Proto4z.BaseProtoObject.encodeDouble(this.triggerCountLimit)); 
            data.AddRange(Proto4z.BaseProtoObject.encodeDouble(this.autoUnloadBuff)); 
            data.AddRange(Proto4z.BaseProtoObject.encodeString(this.desc)); 
            return data; 
        } 
        public int __decode(byte[] binData, ref int pos) 
        { 
            this.id = Proto4z.BaseProtoObject.decodeUI64(binData, ref pos); 
            this.listenTriggerStamp = Proto4z.BaseProtoObject.decodeUI64(binData, ref pos); 
            this.listenTriggerStampText = Proto4z.BaseProtoObject.decodeString(binData, ref pos); 
            this.propID = Proto4z.BaseProtoObject.decodeUI64(binData, ref pos); 
            this.skills = new DictArrayKey(); 
            this.skills.__decode(binData, ref pos); 
            this.skillsText = Proto4z.BaseProtoObject.decodeString(binData, ref pos); 
            this.buffs = new DictArrayKey(); 
            this.buffs.__decode(binData, ref pos); 
            this.buffsText = Proto4z.BaseProtoObject.decodeString(binData, ref pos); 
            this.areaTrigger = Proto4z.BaseProtoObject.decodeDouble(binData, ref pos); 
            this.timerTrigger = Proto4z.BaseProtoObject.decodeDouble(binData, ref pos); 
            this.intervalLimit = Proto4z.BaseProtoObject.decodeDouble(binData, ref pos); 
            this.triggerCountLimit = Proto4z.BaseProtoObject.decodeDouble(binData, ref pos); 
            this.autoUnloadBuff = Proto4z.BaseProtoObject.decodeDouble(binData, ref pos); 
            this.desc = Proto4z.BaseProtoObject.decodeString(binData, ref pos); 
            return pos; 
        } 
    } 
 
    public class DictBuff: Proto4z.IProtoObject 
    {     
        //proto id   
        public const ushort protoID = 11005;  
        static public ushort getProtoID() { return 11005; } 
        static public string getProtoName() { return "DictBuff"; } 
        //members   
        public ulong id;  
        public ulong stamp; //BUFF_STAMP  
        public string stampText;  
        public DictArrayKey effects; //DictBuffEffect ID  
        public string effectsText;  
        public double keepTime;  
        public double limitStackTime; //相同buff叠加时间并且刷新触发次数  
        public string desc;  
        public DictBuff()  
        { 
            id = 0;  
            stamp = 0;  
            stampText = "";  
            effects = new DictArrayKey();  
            effectsText = "";  
            keepTime = 0.0;  
            limitStackTime = 0.0;  
            desc = "";  
        } 
        public DictBuff(ulong id, ulong stamp, string stampText, DictArrayKey effects, string effectsText, double keepTime, double limitStackTime, string desc) 
        { 
            this.id = id; 
            this.stamp = stamp; 
            this.stampText = stampText; 
            this.effects = effects; 
            this.effectsText = effectsText; 
            this.keepTime = keepTime; 
            this.limitStackTime = limitStackTime; 
            this.desc = desc; 
        } 
        public System.Collections.Generic.List<byte> __encode() 
        { 
            var data = new System.Collections.Generic.List<byte>(); 
            data.AddRange(Proto4z.BaseProtoObject.encodeUI64(this.id)); 
            data.AddRange(Proto4z.BaseProtoObject.encodeUI64(this.stamp)); 
            data.AddRange(Proto4z.BaseProtoObject.encodeString(this.stampText)); 
            if (this.effects == null) this.effects = new DictArrayKey(); 
            data.AddRange(this.effects.__encode()); 
            data.AddRange(Proto4z.BaseProtoObject.encodeString(this.effectsText)); 
            data.AddRange(Proto4z.BaseProtoObject.encodeDouble(this.keepTime)); 
            data.AddRange(Proto4z.BaseProtoObject.encodeDouble(this.limitStackTime)); 
            data.AddRange(Proto4z.BaseProtoObject.encodeString(this.desc)); 
            return data; 
        } 
        public int __decode(byte[] binData, ref int pos) 
        { 
            this.id = Proto4z.BaseProtoObject.decodeUI64(binData, ref pos); 
            this.stamp = Proto4z.BaseProtoObject.decodeUI64(binData, ref pos); 
            this.stampText = Proto4z.BaseProtoObject.decodeString(binData, ref pos); 
            this.effects = new DictArrayKey(); 
            this.effects.__decode(binData, ref pos); 
            this.effectsText = Proto4z.BaseProtoObject.decodeString(binData, ref pos); 
            this.keepTime = Proto4z.BaseProtoObject.decodeDouble(binData, ref pos); 
            this.limitStackTime = Proto4z.BaseProtoObject.decodeDouble(binData, ref pos); 
            this.desc = Proto4z.BaseProtoObject.decodeString(binData, ref pos); 
            return pos; 
        } 
    } 
 
    public enum SKILL_STAMP : ulong 
    { 
        SKILL_NONE = 0,  
        SKILL_AUTO_USE = 1, //自动施法  
        SKILL_PASSIVE = 2, //被动技能  
        SKILL_ON_HIT_BREAK = 3, //可被中断  
        SKILL_ON_MOVE_BREAK = 4, //可被中断  
        SKILL_CAN_MOVE = 5, //可移动  
        SKILL_PHYSICAL = 6, //物理类型  
        SKILL_MAGIC = 7, //魔法类型  
        SKILL_HIT = 8, //攻击  
        SKILL_HILL = 9, //治疗  
        SKILL_REMOVE_DEBUFF = 10, //驱散减益BUFF  
        SKILL_REMOVE_BUFF = 11, //驱散增益BUFF  
    }; 
 
    public class DictSkill: Proto4z.IProtoObject 
    {     
        //proto id   
        public const ushort protoID = 11007;  
        static public ushort getProtoID() { return 11007; } 
        static public string getProtoName() { return "DictSkill"; } 
        //members   
        public ulong id;  
        public ulong stamp;  
        public ulong searchID;  
        public double delay; //前摇  
        public double keep; //持续时间  
        public double cd; //冷却  
        public double hpAdd; //附加真实伤害  
        public double hpAddScaleRemanent;  
        public double hpAddScaleLost;  
        public ulong propID; //附加属性提升  
        public double dstTeleport; //目标闪现到自己  
        public double selfTeleport; //自己闪现到目标  
        public double dstMoveTime; //附加给目标朝向自己的位移时间  
        public double dstMoveSpeed; //附加给目标朝向自己的位移速度  
        public double selfMoveTime; //附加给自己朝向目标的位移时间  
        public double selfMoveSpeed; //附加给自己朝向目标的位移速度  
        public DictArrayKey appendBuffs;  
        public string appendBuffsText; //触发buff 格式 k,k,k,   
        public DictArrayKey harmBuffs;  
        public string harmBuffsText; //触发buff 格式 k,k,k,   
        public DictArrayKey nextSkills; //触发技能  
        public string nextSkillsText; //触发技能 格式 k,k,k,   
        public string desc;  
        public DictSkill()  
        { 
            id = 0;  
            stamp = 0;  
            searchID = 0;  
            delay = 0.0;  
            keep = 0.0;  
            cd = 0.0;  
            hpAdd = 0.0;  
            hpAddScaleRemanent = 0.0;  
            hpAddScaleLost = 0.0;  
            propID = 0;  
            dstTeleport = 0.0;  
            selfTeleport = 0.0;  
            dstMoveTime = 0.0;  
            dstMoveSpeed = 0.0;  
            selfMoveTime = 0.0;  
            selfMoveSpeed = 0.0;  
            appendBuffs = new DictArrayKey();  
            appendBuffsText = "";  
            harmBuffs = new DictArrayKey();  
            harmBuffsText = "";  
            nextSkills = new DictArrayKey();  
            nextSkillsText = "";  
            desc = "";  
        } 
        public DictSkill(ulong id, ulong stamp, ulong searchID, double delay, double keep, double cd, double hpAdd, double hpAddScaleRemanent, double hpAddScaleLost, ulong propID, double dstTeleport, double selfTeleport, double dstMoveTime, double dstMoveSpeed, double selfMoveTime, double selfMoveSpeed, DictArrayKey appendBuffs, string appendBuffsText, DictArrayKey harmBuffs, string harmBuffsText, DictArrayKey nextSkills, string nextSkillsText, string desc) 
        { 
            this.id = id; 
            this.stamp = stamp; 
            this.searchID = searchID; 
            this.delay = delay; 
            this.keep = keep; 
            this.cd = cd; 
            this.hpAdd = hpAdd; 
            this.hpAddScaleRemanent = hpAddScaleRemanent; 
            this.hpAddScaleLost = hpAddScaleLost; 
            this.propID = propID; 
            this.dstTeleport = dstTeleport; 
            this.selfTeleport = selfTeleport; 
            this.dstMoveTime = dstMoveTime; 
            this.dstMoveSpeed = dstMoveSpeed; 
            this.selfMoveTime = selfMoveTime; 
            this.selfMoveSpeed = selfMoveSpeed; 
            this.appendBuffs = appendBuffs; 
            this.appendBuffsText = appendBuffsText; 
            this.harmBuffs = harmBuffs; 
            this.harmBuffsText = harmBuffsText; 
            this.nextSkills = nextSkills; 
            this.nextSkillsText = nextSkillsText; 
            this.desc = desc; 
        } 
        public System.Collections.Generic.List<byte> __encode() 
        { 
            var data = new System.Collections.Generic.List<byte>(); 
            data.AddRange(Proto4z.BaseProtoObject.encodeUI64(this.id)); 
            data.AddRange(Proto4z.BaseProtoObject.encodeUI64(this.stamp)); 
            data.AddRange(Proto4z.BaseProtoObject.encodeUI64(this.searchID)); 
            data.AddRange(Proto4z.BaseProtoObject.encodeDouble(this.delay)); 
            data.AddRange(Proto4z.BaseProtoObject.encodeDouble(this.keep)); 
            data.AddRange(Proto4z.BaseProtoObject.encodeDouble(this.cd)); 
            data.AddRange(Proto4z.BaseProtoObject.encodeDouble(this.hpAdd)); 
            data.AddRange(Proto4z.BaseProtoObject.encodeDouble(this.hpAddScaleRemanent)); 
            data.AddRange(Proto4z.BaseProtoObject.encodeDouble(this.hpAddScaleLost)); 
            data.AddRange(Proto4z.BaseProtoObject.encodeUI64(this.propID)); 
            data.AddRange(Proto4z.BaseProtoObject.encodeDouble(this.dstTeleport)); 
            data.AddRange(Proto4z.BaseProtoObject.encodeDouble(this.selfTeleport)); 
            data.AddRange(Proto4z.BaseProtoObject.encodeDouble(this.dstMoveTime)); 
            data.AddRange(Proto4z.BaseProtoObject.encodeDouble(this.dstMoveSpeed)); 
            data.AddRange(Proto4z.BaseProtoObject.encodeDouble(this.selfMoveTime)); 
            data.AddRange(Proto4z.BaseProtoObject.encodeDouble(this.selfMoveSpeed)); 
            if (this.appendBuffs == null) this.appendBuffs = new DictArrayKey(); 
            data.AddRange(this.appendBuffs.__encode()); 
            data.AddRange(Proto4z.BaseProtoObject.encodeString(this.appendBuffsText)); 
            if (this.harmBuffs == null) this.harmBuffs = new DictArrayKey(); 
            data.AddRange(this.harmBuffs.__encode()); 
            data.AddRange(Proto4z.BaseProtoObject.encodeString(this.harmBuffsText)); 
            if (this.nextSkills == null) this.nextSkills = new DictArrayKey(); 
            data.AddRange(this.nextSkills.__encode()); 
            data.AddRange(Proto4z.BaseProtoObject.encodeString(this.nextSkillsText)); 
            data.AddRange(Proto4z.BaseProtoObject.encodeString(this.desc)); 
            return data; 
        } 
        public int __decode(byte[] binData, ref int pos) 
        { 
            this.id = Proto4z.BaseProtoObject.decodeUI64(binData, ref pos); 
            this.stamp = Proto4z.BaseProtoObject.decodeUI64(binData, ref pos); 
            this.searchID = Proto4z.BaseProtoObject.decodeUI64(binData, ref pos); 
            this.delay = Proto4z.BaseProtoObject.decodeDouble(binData, ref pos); 
            this.keep = Proto4z.BaseProtoObject.decodeDouble(binData, ref pos); 
            this.cd = Proto4z.BaseProtoObject.decodeDouble(binData, ref pos); 
            this.hpAdd = Proto4z.BaseProtoObject.decodeDouble(binData, ref pos); 
            this.hpAddScaleRemanent = Proto4z.BaseProtoObject.decodeDouble(binData, ref pos); 
            this.hpAddScaleLost = Proto4z.BaseProtoObject.decodeDouble(binData, ref pos); 
            this.propID = Proto4z.BaseProtoObject.decodeUI64(binData, ref pos); 
            this.dstTeleport = Proto4z.BaseProtoObject.decodeDouble(binData, ref pos); 
            this.selfTeleport = Proto4z.BaseProtoObject.decodeDouble(binData, ref pos); 
            this.dstMoveTime = Proto4z.BaseProtoObject.decodeDouble(binData, ref pos); 
            this.dstMoveSpeed = Proto4z.BaseProtoObject.decodeDouble(binData, ref pos); 
            this.selfMoveTime = Proto4z.BaseProtoObject.decodeDouble(binData, ref pos); 
            this.selfMoveSpeed = Proto4z.BaseProtoObject.decodeDouble(binData, ref pos); 
            this.appendBuffs = new DictArrayKey(); 
            this.appendBuffs.__decode(binData, ref pos); 
            this.appendBuffsText = Proto4z.BaseProtoObject.decodeString(binData, ref pos); 
            this.harmBuffs = new DictArrayKey(); 
            this.harmBuffs.__decode(binData, ref pos); 
            this.harmBuffsText = Proto4z.BaseProtoObject.decodeString(binData, ref pos); 
            this.nextSkills = new DictArrayKey(); 
            this.nextSkills.__decode(binData, ref pos); 
            this.nextSkillsText = Proto4z.BaseProtoObject.decodeString(binData, ref pos); 
            this.desc = Proto4z.BaseProtoObject.decodeString(binData, ref pos); 
            return pos; 
        } 
    } 
 
} 
 
 
