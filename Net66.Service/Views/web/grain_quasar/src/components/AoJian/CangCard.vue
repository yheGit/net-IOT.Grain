<template>
  <div class="grain-stats gt-md-width-1of2 auto">
    <div class="card" :class="{worn:cang.AverageTemperature>35,error:cang.AverageTemperature>45}">
      <div class="item">
        <div class="item-content has-secondary">
          {{cang.Location}}
        </div>
        <span class="cangStatus"></span>
        <span class="item-secondary" @click="toggle">
          <i>autorenew</i>
        </span>
      </div>
      <div class="list bordered inner-delimiter highlight">
        <div class="item">
          <div class="item-content">
            <span class="item-label">
              粮堆编号：
            </span>
            <span class="item-value">
              {{cang.Number}}
            </span>
          </div>
        </div>
        <div class="item">
          <div class="item-content">
            <span class="item-label">
              平均温度：
            </span>
            <span class="item-value">
              {{cang.AverageTemperature}}°C
            </span>
          </div>
        </div>
        <div class="item">
          <div class="item-content">
            <span class="item-label">
              平均湿度：
            </span>
            <span class="item-value">
              {{cang.AverageHumidity}}%
            </span>
          </div>
        </div>
        <chuanganpingmian :code="cang.Number" v-if="PM"></chuanganpingmian>
        <chuangan3d :code="cang.Number" v-else></chuangan3d>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  props: ['cang'],
  data() {
    return {
      PM: false,
    };
  },
  methods: {
    toggle() {
      this.PM = !this.PM;
    },
  },
};
</script>

<style lang="less" scoped>
.cangStatus{
  width: 20px;
  height: 20px;
  margin: 16px;
  position: absolute;
  top: 0;
  right: 30px;
}
.card{
  border: 1px solid rgba(156,202,134,0.48);
  box-shadow: 0 1px 3px rgba(156,202,134,0.12), 0 1px 2px rgba(156,202,134,24);
  .cangStatus{
    background-color: rgba(156,202,134,1);
  }
}
.card.worn{
  border: 1px solid rgba(237,125,49,0.48);
  box-shadow: 0 1px 3px rgba(237,125,49,0.12), 0 1px 2px rgba(237,125,49,0.24);
  .cangStatus{
    background-color: rgba(237,125,49,1);
  }
}
.card.error{
  border: 1px solid rgba(156,3,3,0.48);
  box-shadow: 0 1px 3px rgba(156,3,3,0.12), 0 1px 2px rgba(156,3,3,0.24);
  .cangStatus{
    background-color: rgba(156,3,3,1);
  }
}
</style>