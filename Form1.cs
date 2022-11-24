using System.Data;

namespace Ecom
{
    public partial class AMainForm : Form
    {
        public AMainForm()
        {
            InitializeComponent();
        }

        private void picb_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btt_iphone_Click(object sender, EventArgs e)
        {

        }

        private void btt_aud_Click(object sender, EventArgs e)
        {

        }

        private void btt_ipad_Click(object sender, EventArgs e)
        {

        }

        private void btt_watch_Click(object sender, EventArgs e)
        {

        }

        private void btt_mac_Click(object sender, EventArgs e)
        {

        }

        private void btt_acs_Click(object sender, EventArgs e)
        {

        }

        private void btt_acs_MouseEnter(object sender, EventArgs e)
        {
            btt_acs.BackColor = Color.FromArgb(45, 45, 45);
        }
        private void btt_acs_MouseLeave(object sender, EventArgs e)
        {
            btt_acs.BackColor = Color.FromArgb(16, 16, 16);
        }

        private void btt_iphone_MouseEnter(object sender, EventArgs e)
        {
            btt_iphone.BackColor = Color.FromArgb(45, 45, 45);
        }
        private void btt_iphone_MouseLeave(object sender, EventArgs e)
        {
            //btt_acs.BackColor = Color.FromArgb(45, 45, 45);
        }

        private void btt_mac_MouseEnter(object sender, EventArgs e)
        {
            btt_mac.BackColor = Color.FromArgb(45, 45, 45);
        }

        private void btt_iphone_MouseLeave_1(object sender, EventArgs e)
        {
            btt_iphone.BackColor = Color.FromArgb(16, 16, 16);
        }

        private void btt_mac_MouseLeave(object sender, EventArgs e)
        {
            btt_mac.BackColor = Color.FromArgb(16, 16, 16);

        }

        private void btt_ipad_MouseEnter(object sender, EventArgs e)
        {
            btt_ipad.BackColor = Color.FromArgb(45, 45, 45);
        }

        private void btt_ipad_MouseLeave(object sender, EventArgs e)
        {
            btt_ipad.BackColor = Color.FromArgb(16, 16, 16);
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pan_titlebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picb_search_Click(object sender, EventArgs e)
        {

        }

        private void logo_apple_Click(object sender, EventArgs e)
        {

        }

        private void pan_home_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void picb_appro2_Click(object sender, EventArgs e)
        {

        }

        private void picb_apmax_Click(object sender, EventArgs e)
        {

        }

        private void picb_ap3_Click(object sender, EventArgs e)
        {

        }

        private void picb_ap2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void picb_watch_Click(object sender, EventArgs e)
        {

        }

        private void picb_watch_se_Click(object sender, EventArgs e)
        {

        }

        private void picb_watch_hermes_Click(object sender, EventArgs e)
        {

        }

        private void picb_watch_s8_Click(object sender, EventArgs e)
        {

        }

        private void picb_watch_ultra_Click(object sender, EventArgs e)
        {

        }

        private void picb_ipad10_Click(object sender, EventArgs e)
        {

        }

        private void picb_ipadmini_Click(object sender, EventArgs e)
        {

        }

        private void picb_ipadair_Click(object sender, EventArgs e)
        {

        }

        private void picb_ipadpro_Click(object sender, EventArgs e)
        {

        }

        private void picb_ipad_Click(object sender, EventArgs e)
        {

        }

        private void picb_mac_Click(object sender, EventArgs e)
        {

        }

        private void picb_macair_Click(object sender, EventArgs e)
        {

        }

        private void picb_imac_Click(object sender, EventArgs e)
        {

        }

        private void picb_mac14_Click(object sender, EventArgs e)
        {

        }

        private void picb_mac16_Click(object sender, EventArgs e)
        {

        }

        private void picb_14plus_Click(object sender, EventArgs e)
        {

        }

        private void picb_14_Click(object sender, EventArgs e)
        {

        }

        private void picb_14pro_Click(object sender, EventArgs e)
        {

        }

        private void picb_14promax_Click(object sender, EventArgs e)
        {

        }

        private void cat_aud_Click(object sender, EventArgs e)
        {

        }

        private void picb_iphone_Click(object sender, EventArgs e)
        {

        }

        private void cat_ipad_Click(object sender, EventArgs e)
        {

        }

        private void cat_watch_Click(object sender, EventArgs e)
        {

        }

        private void cat_mac_Click(object sender, EventArgs e)
        {

        }

        private void cat_iphone_Click(object sender, EventArgs e)
        {

        }

        private void picb_ads_Click(object sender, EventArgs e)
        {

        }

        private void btt_acs_Click_1(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is Panel && c != pan_titlebar && c != pan_acs) c.Visible = false;
            }
            pan_acs.Visible = true;
        }

        private void pan_iphone_lab_all_MouseEnter(object sender, EventArgs e)
        {
            pan_iphone_lab_all.Font = new Font(pan_iphone_lab_all.Font, FontStyle.Underline | FontStyle.Bold);
        }

        private void pan_iphone_lab_all_MouseLeave(object sender, EventArgs e)
        {
            pan_iphone_lab_all.Font = new Font(pan_iphone_lab_all.Font, FontStyle.Regular);
        }

        private void pan_iphone_lab_ip14pro_MouseEnter(object sender, EventArgs e)
        {
            pan_iphone_lab_ip14pro.Font = new Font(pan_iphone_lab_ip14pro.Font, FontStyle.Underline | FontStyle.Bold);

        }

        private void pan_iphone_lab_ip14pro_MouseLeave(object sender, EventArgs e)
        {
            pan_iphone_lab_ip14pro.Font = new Font(pan_iphone_lab_ip14pro.Font, FontStyle.Regular);
        }

        private void pan_iphone_lab_ip14_MouseEnter(object sender, EventArgs e)
        {
            pan_iphone_lab_ip14.Font = new Font(pan_iphone_lab_ip14.Font, FontStyle.Underline | FontStyle.Bold);
        }

        private void pan_iphone_lab_ip14_MouseLeave(object sender, EventArgs e)
        {
            pan_iphone_lab_ip14.Font = new Font(pan_iphone_lab_ip14.Font, FontStyle.Regular);
        }

        private void pan_iphone_lab_ip13_MouseEnter(object sender, EventArgs e)
        {
            pan_iphone_lab_ip13.Font = new Font(pan_iphone_lab_ip13.Font, FontStyle.Underline | FontStyle.Bold);
        }

        private void pan_iphone_lab_ip13_MouseLeave(object sender, EventArgs e)
        {
            pan_iphone_lab_ip13.Font = new Font(pan_iphone_lab_ip13.Font, FontStyle.Regular);
        }

        private void btt_iphone_Click_1(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is Panel && c != pan_titlebar && c != pan_iphone) c.Visible = false;
            }
            pan_iphone.Visible = true;
        }

        private void logo_apple_Click_1(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is Panel && c != pan_titlebar && c != pan_home) c.Visible = false;
            }
            pan_home.Visible = true;
        }

        private void btt_mac_Click_1(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is Panel && c != pan_titlebar && c != pan_mac) c.Visible = false;
            }
            pan_mac.Visible = true;
        }

        private void pan_mac_lab_all_MouseEnter(object sender, EventArgs e)
        {
            pan_mac_lab_all.Font = new Font(pan_mac_lab_all.Font, FontStyle.Underline | FontStyle.Bold);
        }

        private void pan_mac_lab_all_MouseLeave(object sender, EventArgs e)
        {
            pan_mac_lab_all.Font = new Font(pan_mac_lab_all.Font, FontStyle.Regular);
        }

        private void pan_mac_lab_pro_MouseEnter(object sender, EventArgs e)
        {
            pan_mac_lab_pro.Font = new Font(pan_mac_lab_pro.Font, FontStyle.Underline | FontStyle.Bold);

        }

        private void pan_mac_lab_pro_MouseLeave(object sender, EventArgs e)
        {
            pan_mac_lab_pro.Font = new Font(pan_mac_lab_all.Font, FontStyle.Regular);

        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            pan_mac_lab_air.Font = new Font(pan_mac_lab_air.Font, FontStyle.Underline | FontStyle.Bold);
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            pan_mac_lab_air.Font = new Font(pan_mac_lab_air.Font, FontStyle.Regular);

        }
        private void pan_mac_lab_imac_MouseEnter(object sender, EventArgs e)
        {
            pan_mac_lab_imac.Font = new Font(pan_mac_lab_imac.Font, FontStyle.Underline | FontStyle.Bold);
        }

        private void pan_mac_lab_imac_MouseLeave(object sender, EventArgs e)
        {
            pan_mac_lab_imac.Font = new Font(pan_mac_lab_imac.Font, FontStyle.Regular);
        }

        private void btt_ipad_Click_1(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is Panel && c != pan_titlebar && c != pan_ipad) c.Visible = false;
            }
            pan_ipad.Visible = true;

        }

        private void pan_acs_lab_all_MouseEnter(object sender, EventArgs e)
        {
            pan_acs_lab_all.Font = new Font(pan_acs_lab_all.Font, FontStyle.Underline | FontStyle.Bold);

        }

        private void pan_acs_lab_all_MouseLeave(object sender, EventArgs e)
        {
            pan_acs_lab_all.Font = new Font(pan_acs_lab_all.Font, FontStyle.Regular);
        }

        private void pan_acs_lab_watch_MouseEnter(object sender, EventArgs e)
        {
            pan_acs_lab_watch.Font = new Font(pan_acs_lab_watch.Font, FontStyle.Underline | FontStyle.Bold);

        }

        private void pan_acs_lab_watch_MouseLeave(object sender, EventArgs e)
        {
            pan_acs_lab_watch.Font = new Font(pan_acs_lab_watch.Font, FontStyle.Regular);

        }

        private void pan_acs_lab_airpods_MouseEnter(object sender, EventArgs e)
        {
            pan_acs_lab_airpods.Font = new Font(pan_acs_lab_airpods.Font, FontStyle.Underline | FontStyle.Bold);

        }

        private void pan_acs_lab_airpods_MouseLeave(object sender, EventArgs e)
        {
            pan_acs_lab_airpods.Font = new Font(pan_acs_lab_airpods.Font, FontStyle.Regular);

        }

        private void pan_acs_lab_other_MouseEnter(object sender, EventArgs e)
        {
            pan_acs_lab_other.Font = new Font(pan_acs_lab_other.Font, FontStyle.Underline | FontStyle.Bold);

        }

        private void pan_acs_lab_other_MouseLeave(object sender, EventArgs e)
        {
            pan_acs_lab_other.Font = new Font(pan_acs_lab_other.Font, FontStyle.Regular);

        }

        private void pan_detail_lab_price_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pan_iphone_picb_14promax_Click(object sender, EventArgs e)
        {
            pan_detail.Visible = true;
            pan_detial_picb_product.Image = Properties.Resources.iphone_1;
            pan_detail_lab_name.Text = pan_iphone_lab_14pm.Text;
            pan_detail_lab_price.Text = iphone_14promax_price.Text;
            pan_detail_lab_promo.Text = "•  Giảm thêm tới 1.000.000đ khi mở thẻ tín dụng đồng thương hiệu TPBank EVO\r\n•  Giảm thêm 500.000đ khi thanh toán qua VNPAY\r\n•  [HOT] Thu cũ lên đời giá cao - Thủ tục nhanh - Trợ giá lên tới 1.000.000đ\r\n";
            pan_detail_lab_policy.Text = "📦 Bộ sản phẩm gồm: Hộp, Sách hướng dẫn, Cây lấy sim, Cáp Lightning - Type C\r\n🔄 Bảo hành chính hãng 1 năm\r\n🚚 Miễn phí giao hàng\r\n\r\n";
            pan_detail_lab_feature.Text = "ĐẶC ĐIỂM NỔI BẬT\r\n\r\n•  Màn hình Dynamic Island - Sự biến mất của màn hình tai thỏ thay thế bằng thiết kế viên thuốc, OLED 6,7 inch, hỗ trợ always-on display\r\n\r\n•  Cấu hình iPhone 14 Pro Max mạnh mẽ, hiệu năng cực khủng từ chipset A16 Bionic\r\n\r\n•  Làm chủ công nghệ nhiếp ảnh - Camera sau 48MP, cảm biến TOF sống động\r\n\r\n•  Pin liền lithium-ion kết hợp cùng công nghệ sạc nhanh cải tiến\r\n";
            label3.Text = "🌱 Mục tiêu môi trường của chúng tôi.\r\n\r\n     Là một phần trong nỗ lực của chúng tôi nhằm đạt được mức trung hòa carbon vào năm 2030, iPhone 14 series không bao gồm bộ đổi nguồn hoặc EarPods. Đi kèm trong hộp là Cáp USB‑C to Lightning hỗ trợ sạc nhanh và tương thích với bộ điều hợp nguồn USB‑C và cổng máy tính.\r\n  \r\n     Chúng tôi khuyến khích bạn sử dụng lại cáp USB‑A to Lightning, bộ điều hợp nguồn và tai nghe tương thích với các mẫu iPhone này. Nhưng nếu bạn cần bất kỳ bộ điều hợp nguồn hoặc tai nghe mới nào của Apple, chúng đều có sẵn để mua.\r\n";
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            pan_detail.Visible = false;
        }

        private void pan_iphone_picb_14pro_Click(object sender, EventArgs e)
        {
            pan_detail.Visible = true;
            pan_detial_picb_product.Image = Properties.Resources.iphone_2;
            pan_detail_lab_name.Text = pan_iphone_lab_14pro.Text;
            pan_detail_lab_price.Text = iphone_14pro_price.Text;
            pan_detail_lab_promo.Text = "•  Giảm thêm tới 1.000.000đ khi mở thẻ tín dụng đồng thương hiệu TPBank EVO\r\n•  Giảm thêm 500.000đ khi thanh toán qua VNPAY\r\n•  [HOT] Thu cũ lên đời giá cao - Thủ tục nhanh - Trợ giá lên tới 1.000.000đ\r\n";
            pan_detail_lab_policy.Text = "📦 Bộ sản phẩm gồm: Hộp, Sách hướng dẫn, Cây lấy sim, Cáp Lightning - Type C\r\n🔄 Bảo hành chính hãng 1 năm\r\n🚚 Miễn phí giao hàng\r\n\r\n";
            pan_detail_lab_feature.Text = "ĐẶC ĐIỂM NỔI BẬT\r\n\r\n•  Màn hình Dynamic Island - Sự biến mất của màn hình tai thỏ thay thế bằng thiết kế viên thuốc, OLED 6,7 inch, hỗ trợ always-on display\r\n\r\n•  Cấu hình iPhone 14 Pro Max mạnh mẽ, hiệu năng cực khủng từ chipset A16 Bionic\r\n\r\n•  Làm chủ công nghệ nhiếp ảnh - Camera sau 48MP, cảm biến TOF sống động\r\n\r\n•  Pin liền lithium-ion kết hợp cùng công nghệ sạc nhanh cải tiến\r\n";
            label3.Text = "🌱 Mục tiêu môi trường của chúng tôi.\r\n\r\n     Là một phần trong nỗ lực của chúng tôi nhằm đạt được mức trung hòa carbon vào năm 2030, iPhone 14 series không bao gồm bộ đổi nguồn hoặc EarPods. Đi kèm trong hộp là Cáp USB‑C to Lightning hỗ trợ sạc nhanh và tương thích với bộ điều hợp nguồn USB‑C và cổng máy tính.\r\n  \r\n     Chúng tôi khuyến khích bạn sử dụng lại cáp USB‑A to Lightning, bộ điều hợp nguồn và tai nghe tương thích với các mẫu iPhone này. Nhưng nếu bạn cần bất kỳ bộ điều hợp nguồn hoặc tai nghe mới nào của Apple, chúng đều có sẵn để mua.\r\n";

        }

        private void pan_iphone_picb_14plus_Click(object sender, EventArgs e)
        {
            pan_detail.Visible = true;
            pan_detial_picb_product.Image = Properties.Resources.iphone_3;
            pan_detail_lab_name.Text = pan_iphone_lab_14plus.Text;
            pan_detail_lab_price.Text = iphone_14plus_price.Text;
            pan_detail_lab_promo.Text = "•  Giảm thêm tới 1.000.000đ khi mở thẻ tín dụng đồng thương hiệu TPBank EVO\r\n•  Giảm thêm 500.000đ khi thanh toán qua VNPAY\r\n•  [HOT] Thu cũ lên đời giá cao - Thủ tục nhanh - Trợ giá lên tới 1.000.000đ\r\n";
            pan_detail_lab_policy.Text = "📦 Bộ sản phẩm gồm: Hộp, Sách hướng dẫn, Cây lấy sim, Cáp Lightning - Type C\r\n🔄 Bảo hành chính hãng 1 năm\r\n🚚 Miễn phí giao hàng\r\n\r\n";
            pan_detail_lab_feature.Text = "ĐẶC ĐIỂM NỔI BẬT\r\n\r\n•  Trải nghiệm thị giác ấn tượng - Màn hình lớn 6.7\" sắc nét với công nghệ Super Retina XDR\r\n\r\n•  Sử dụng lâu dài với viên pin lớn giúp phát video liên tục lên tới 26 giờ\r\n\r\n•  Tuyệt đỉnh thiết kế, tỉ mỉ từng đường nét - Nâng cấp toàn diện với kiểu dáng mới, nhiều lựa chọn màu sắc trẻ trung\r\n\r\n•  Hiệu năng hàng đầu thế giới - Apple A15 Bionic 6 nhân xử lí nhanh, ổn định\r\n";
            label3.Text = "🌱 Mục tiêu môi trường của chúng tôi.\r\n\r\n     Là một phần trong nỗ lực của chúng tôi nhằm đạt được mức trung hòa carbon vào năm 2030, iPhone 14 series không bao gồm bộ đổi nguồn hoặc EarPods. Đi kèm trong hộp là Cáp USB‑C to Lightning hỗ trợ sạc nhanh và tương thích với bộ điều hợp nguồn USB‑C và cổng máy tính.\r\n  \r\n     Chúng tôi khuyến khích bạn sử dụng lại cáp USB‑A to Lightning, bộ điều hợp nguồn và tai nghe tương thích với các mẫu iPhone này. Nhưng nếu bạn cần bất kỳ bộ điều hợp nguồn hoặc tai nghe mới nào của Apple, chúng đều có sẵn để mua.\r\n";
}

        private void pan_iphone_picb_14_Click(object sender, EventArgs e)
        {
            pan_detail.Visible = true;
            pan_detial_picb_product.Image = Properties.Resources.iphone_4;
            pan_detail_lab_name.Text = pan_iphone_lab_14.Text;
            pan_detail_lab_price.Text = iphone_14_price.Text;
            pan_detail_lab_promo.Text = "•  Giảm thêm tới 1.000.000đ khi mở thẻ tín dụng đồng thương hiệu TPBank EVO\r\n•  Giảm thêm 500.000đ khi thanh toán qua VNPAY\r\n•  [HOT] Thu cũ lên đời giá cao - Thủ tục nhanh - Trợ giá lên tới 1.000.000đ\r\n";
            pan_detail_lab_policy.Text = "📦 Bộ sản phẩm gồm: Hộp, Sách hướng dẫn, Cây lấy sim, Cáp Lightning - Type C\r\n🔄 Bảo hành chính hãng 1 năm\r\n🚚 Miễn phí giao hàng\r\n\r\n";
            pan_detail_lab_feature.Text = "ĐẶC ĐIỂM NỔI BẬT\r\n\r\n•  Tuyệt đỉnh thiết kế, tỉ mỉ từng đường nét - Nâng cấp toàn diện với kiểu dáng mới, nhiều lựa chọn màu sắc trẻ trung\r\n\r\n•  Nâng tầm trải ngiệm giải trí đỉnh cao - Màn hình 6,1\" cùng tấm nền OLED có công nghệ Super Retina XDR cao cấp\r\n\r\n•  Chụp ảnh chuyên nghiệp hơn - Cụm 2 camera 12 MP đi kèm nhiều chế độ và chức năng chụp hiện đại\r\n\r\n•  Hiệu năng hàng đầu thế giới - Apple A15 Bionic 6 nhân xử lí nhanh, ổn định\r\n";
            label3.Text = "🌱 Mục tiêu môi trường của chúng tôi.\r\n\r\n     Là một phần trong nỗ lực của chúng tôi nhằm đạt được mức trung hòa carbon vào năm 2030, iPhone 14 series không bao gồm bộ đổi nguồn hoặc EarPods. Đi kèm trong hộp là Cáp USB‑C to Lightning hỗ trợ sạc nhanh và tương thích với bộ điều hợp nguồn USB‑C và cổng máy tính.\r\n  \r\n     Chúng tôi khuyến khích bạn sử dụng lại cáp USB‑A to Lightning, bộ điều hợp nguồn và tai nghe tương thích với các mẫu iPhone này. Nhưng nếu bạn cần bất kỳ bộ điều hợp nguồn hoặc tai nghe mới nào của Apple, chúng đều có sẵn để mua.\r\n";
}

        private void pan_iphone_picb_13_Click(object sender, EventArgs e)
        {
            pan_detail.Visible = true;
            pan_detial_picb_product.Image = Properties.Resources.iphone_5;
            pan_detail_lab_name.Text = pan_iphone_lab_13.Text;
            pan_detail_lab_price.Text = iphone_13_price.Text;
            pan_detail_lab_promo.Text = "•  Giảm thêm tới 1.000.000đ khi mở thẻ tín dụng đồng thương hiệu TPBank EVO\r\n•  Giảm thêm 500.000đ khi thanh toán qua VNPAY\r\n•  [HOT] Thu cũ lên đời giá cao - Thủ tục nhanh - Trợ giá lên tới 1.000.000đ\r\n";
            pan_detail_lab_policy.Text = "📦 Bộ sản phẩm gồm: Hộp, Sách hướng dẫn, Cây lấy sim, Cáp Lightning - Type C\r\n🔄 Bảo hành chính hãng 1 năm\r\n🚚 Miễn phí giao hàng\r\n\r\n";
            pan_detail_lab_feature.Text = "ĐẶC ĐIỂM NỔI BẬT\r\n\r\n•  Hiệu năng vượt trội - Chip Apple A15 Bionic mạnh mẽ, hỗ trợ mạng 5G tốc độ cao\r\n\r\n•  Không gian hiển thị sống động - Màn hình 6.1\" Super Retina XDR độ sáng cao, sắc nét\r\n\r\n•  Trải nghiệm điện ảnh đỉnh cao - Camera kép 12MP, hỗ trợ ổn định hình ảnh quang học\r\n\r\n•  Tối ưu điện năng - Sạc nhanh 20 W, đầy 50% pin trong khoảng 30 phút\r\n";
            label3.Text = "🌱 Mục tiêu môi trường của chúng tôi.\r\n\r\n     Là một phần trong nỗ lực của chúng tôi nhằm đạt được mức trung hòa carbon vào năm 2030, iPhone 13 series không bao gồm bộ đổi nguồn hoặc EarPods. Đi kèm trong hộp là Cáp USB‑C to Lightning hỗ trợ sạc nhanh và tương thích với bộ điều hợp nguồn USB‑C và cổng máy tính.\r\n  \r\n     Chúng tôi khuyến khích bạn sử dụng lại cáp USB‑A to Lightning, bộ điều hợp nguồn và tai nghe tương thích với các mẫu iPhone này. Nhưng nếu bạn cần bất kỳ bộ điều hợp nguồn hoặc tai nghe mới nào của Apple, chúng đều có sẵn để mua.\r\n";
}

        private void pan_iphone_picb_13mini_Click(object sender, EventArgs e)
        {
            pan_detail.Visible = true;
            pan_detial_picb_product.Image = Properties.Resources.iphone_6;
            pan_detail_lab_name.Text = pan_iphone_lab_13mini.Text;
            pan_detail_lab_price.Text = iphone_13mini_price.Text;
            pan_detail_lab_promo.Text = "•  Giảm thêm tới 1.000.000đ khi mở thẻ tín dụng đồng thương hiệu TPBank EVO\r\n•  Giảm thêm 500.000đ khi thanh toán qua VNPAY\r\n•  [HOT] Thu cũ lên đời giá cao - Thủ tục nhanh - Trợ giá lên tới 1.000.000đ\r\n";
            pan_detail_lab_policy.Text = "📦 Bộ sản phẩm gồm: Hộp, Sách hướng dẫn, Cây lấy sim, Cáp Lightning - Type C\r\n🔄 Bảo hành chính hãng 1 năm\r\n🚚 Miễn phí giao hàng\r\n\r\n";
            pan_detail_lab_feature.Text = "ĐẶC ĐIỂM NỔI BẬT\r\n\r\n•  Hiệu năng vượt trội - Chip Apple A15 Bionic mạnh mẽ, hỗ trợ mạng 5G tốc độ cao\r\n\r\n•  Không gian hiển thị sống động - Màn hình 5.4\" Super Retina XDR độ sáng cao, sắc nét\r\n\r\n•  Trải nghiệm điện ảnh đỉnh cao - Camera kép 12MP, hỗ trợ ổn định hình ảnh quang học\r\n\r\n•  Tối ưu điện năng - Sạc nhanh 20 W, đầy 50% pin trong khoảng 30 phút\r\n";
            label3.Text = "🌱 Mục tiêu môi trường của chúng tôi.\r\n\r\n     Là một phần trong nỗ lực của chúng tôi nhằm đạt được mức trung hòa carbon vào năm 2030, iPhone 13 series không bao gồm bộ đổi nguồn hoặc EarPods. Đi kèm trong hộp là Cáp USB‑C to Lightning hỗ trợ sạc nhanh và tương thích với bộ điều hợp nguồn USB‑C và cổng máy tính.\r\n  \r\n     Chúng tôi khuyến khích bạn sử dụng lại cáp USB‑A to Lightning, bộ điều hợp nguồn và tai nghe tương thích với các mẫu iPhone này. Nhưng nếu bạn cần bất kỳ bộ điều hợp nguồn hoặc tai nghe mới nào của Apple, chúng đều có sẵn để mua.\r\n";
}

        private void pan_mac_picb_pro16_Click(object sender, EventArgs e)
        {
            pan_detail.Visible = true;
            pan_detial_picb_product.Image = Properties.Resources.mac_1;
            pan_detail_lab_name.Text = pan_mac_lab_mac1.Text;
            pan_detail_lab_price.Text = mac_1_price.Text;
            pan_detail_lab_promo.Text = "•  Giảm thêm 500.000đ khi thanh toán qua VNPAY\r\n•  Thu cũ lên đời - Trợ giá 1 triệu (Tuỳ model máy cũ, không áp dụng cùng ưu đãi cổng thanh toán)\r\n•  Voucher mua Office Home & Student 2021 chỉ còn 2,090,000\r\n";
            pan_detail_lab_policy.Text = "📦 Bộ sản phẩm gồm: Hộp, Cáp Type C to MagSafe, \r\nSách hướng dẫn, Adapter USB-C\r\n🔄 Bảo hành chính hãng 1 năm\r\n🚚 Miễn phí giao hàng\r\n";
            pan_detail_lab_feature.Text = "ĐẶC ĐIỂM NỔI BẬT\r\n\r\n•  Thiết kế sang trọng - mỏng chỉ 16.68mm, trọng lượng 2.1kg\r\n\r\n•  Hiệu năng hàng đầu - Chip Apple M1 Max cho tốc độ xử lý nhanh chóng với các phần mềm như word, Excel hay các ứng dụng đồ hoạ Premier, AutoCAD\r\n\r\n•  Ram 32GB cho tốc độ load ứng dụng thần tốc, mở cùng lúc nhiều app khi làm việc\r\n\r\n•  Ổ cứng 1TB cho phép lưu trữ cả những video 4K nặng nề hay những bộ phim yêu thích\r\n\r\n•  Bảo mật tốt - Trang bị cảm biến vân tay mở máy chỉ với 1 lần chạm\r\n";
            label3.Text = "AppleCare+ cho máy Mac\r\n\r\nMọi máy Mac đều được bảo hành một năm và hỗ trợ kỹ thuật miễn phí lên đến 90 ngày. \r\n\r\nAppleCare+ cho Mac mở rộng phạm vi bảo hành của bạn lên ba năm kể từ ngày mua AppleCare+ và thêm các sự cố bảo vệ thiệt hại do tai nạn không giới hạn, mỗi trường hợp phải chịu phí dịch vụ $99 đối với hư hỏng màn hình hoặc thân máy hoặc $299 đối với các hư hỏng khác. \r\n\r\nNgoài ra, bạn sẽ được ưu tiên tiếp cận các chuyên gia của Apple 24/7 qua trò chuyện hoặc điện thoại thông qua getsupport.apple.com.\r\n";
}

        private void pan_mac_picb_pro14_Click(object sender, EventArgs e)
        {
            pan_detail.Visible = true;
            pan_detial_picb_product.Image = Properties.Resources.mac_2;
            pan_detail_lab_name.Text = pan_mac_lab_mac2.Text;
            pan_detail_lab_price.Text = mac_2_price.Text;
            pan_detail_lab_promo.Text = "•  Giảm thêm 500.000đ khi thanh toán qua VNPAY\r\n•  Thu cũ lên đời - Trợ giá 1 triệu (Tuỳ model máy cũ, không áp dụng cùng ưu đãi cổng thanh toán)\r\n•  Voucher mua Office Home & Student 2021 chỉ còn 2,090,000\r\n";
            pan_detail_lab_policy.Text = "📦 Bộ sản phẩm gồm: Hộp, Cáp Type C to MagSafe, \r\nSách hướng dẫn, Adapter USB-C\r\n🔄 Bảo hành chính hãng 1 năm\r\n🚚 Miễn phí giao hàng\r\n";
            pan_detail_lab_feature.Text = "ĐẶC ĐIỂM NỔI BẬT\r\n\r\n•  Thiết kế sang trọng - mỏng chỉ 15.5mm, trọng lượng 1.6kg\r\n\r\n•  Hiệu năng hàng đầu - Chip Apple M1 Max cho tốc độ xử lý nhanh chóng với các phần mềm như word, Excel hay các ứng dụng đồ hoạ Premier, AutoCAD\r\n\r\n•  Ram 32GB cho tốc độ load ứng dụng thần tốc, mở cùng lúc nhiều app khi làm việc\r\n\r\n•  Ổ cứng 1TB cho phép lưu trữ cả những video 4K nặng nề hay những bộ phim yêu thích\r\n\r\n•  Bảo mật tốt - Trang bị cảm biến vân tay mở máy chỉ với 1 lần chạm\r\n";
            label3.Text = "AppleCare+ cho máy Mac\r\n\r\nMọi máy Mac đều được bảo hành một năm và hỗ trợ kỹ thuật miễn phí lên đến 90 ngày. \r\n\r\nAppleCare+ cho Mac mở rộng phạm vi bảo hành của bạn lên ba năm kể từ ngày mua AppleCare+ và thêm các sự cố bảo vệ thiệt hại do tai nạn không giới hạn, mỗi trường hợp phải chịu phí dịch vụ $99 đối với hư hỏng màn hình hoặc thân máy hoặc $299 đối với các hư hỏng khác. \r\n\r\nNgoài ra, bạn sẽ được ưu tiên tiếp cận các chuyên gia của Apple 24/7 qua trò chuyện hoặc điện thoại thông qua getsupport.apple.com.\r\n";
        }

        private void pan_mac_picb_air1_Click(object sender, EventArgs e)
        {
            pan_detail.Visible = true;
            pan_detial_picb_product.Image = Properties.Resources.mac_3;
            pan_detail_lab_name.Text = pan_mac_lab_mac3.Text;
            pan_detail_lab_price.Text = mac_3_price.Text;
            pan_detail_lab_promo.Text = "•  Giảm thêm 500.000đ khi thanh toán qua VNPAY\r\n•  Thu cũ lên đời - Trợ giá 1 triệu (Tuỳ model máy cũ, không áp dụng cùng ưu đãi cổng thanh toán)\r\n•  Voucher mua Office Home & Student 2021 chỉ còn 2,090,000\r\n";
            pan_detail_lab_policy.Text = "📦 Bộ sản phẩm gồm: Hộp, Cáp Type C to MagSafe, \r\nSách hướng dẫn, Adapter USB-C\r\n🔄 Bảo hành chính hãng 1 năm\r\n🚚 Miễn phí giao hàng\r\n";
            pan_detail_lab_feature.Text = "ĐẶC ĐIỂM NỔI BẬT\r\n\r\n•  Thiết kế sang trọng, lịch lãm - siêu mỏng 11.3mm, chỉ 1.24kg\r\n\r\n•  Hiệu năng hàng đầu - Chip Apple M2, 10 nhân GPU, hỗ trợ tốt các phần mềm như Word, Axel, Adobe Premier\r\n\r\n•  Đa nhiệm mượt mà - Ram 8GB, SSD 512GB cho phép vừa làm việc, vừa nghe nhạc\r\n\r\n•  Màn hình sắc nét - Độ phân giải 2560 x 1664 cùng độ sáng 500 nits\r\n\r\n•  Âm thanh sống động - 4 loa trang bị công nghệ dolby atmos và âm thanh đa chiều\r\n";
            label3.Text = "AppleCare+ cho máy Mac\r\n\r\nMọi máy Mac đều được bảo hành một năm và hỗ trợ kỹ thuật miễn phí lên đến 90 ngày. \r\n\r\nAppleCare+ cho Mac mở rộng phạm vi bảo hành của bạn lên ba năm kể từ ngày mua AppleCare+ và thêm các sự cố bảo vệ thiệt hại do tai nạn không giới hạn, mỗi trường hợp phải chịu phí dịch vụ $99 đối với hư hỏng màn hình hoặc thân máy hoặc $299 đối với các hư hỏng khác. \r\n\r\nNgoài ra, bạn sẽ được ưu tiên tiếp cận các chuyên gia của Apple 24/7 qua trò chuyện hoặc điện thoại thông qua getsupport.apple.com.\r\n";
        }

        private void pan_mac_picb_air2_Click(object sender, EventArgs e)
        {
            pan_detail.Visible = true;
            pan_detial_picb_product.Image = Properties.Resources.mac_4;
            pan_detail_lab_name.Text = pan_mac_lab_mac4.Text;
            pan_detail_lab_price.Text = mac_4_price.Text;
            pan_detail_lab_promo.Text = "•  Giảm thêm 500.000đ khi thanh toán qua VNPAY\r\n•  Thu cũ lên đời - Trợ giá 1 triệu (Tuỳ model máy cũ, không áp dụng cùng ưu đãi cổng thanh toán)\r\n•  Voucher mua Office Home & Student 2021 chỉ còn 2,090,000\r\n";
            pan_detail_lab_policy.Text = "📦 Bộ sản phẩm gồm: Hộp, Cáp Type C to MagSafe, \r\nSách hướng dẫn, Adapter USB-C\r\n🔄 Bảo hành chính hãng 1 năm\r\n🚚 Miễn phí giao hàng\r\n";
            pan_detail_lab_feature.Text = "ĐẶC ĐIỂM NỔI BẬT\r\n\r\n•  Thiết kế sang trọng, lịch lãm - siêu mỏng 11.3mm, chỉ 1.24kg\r\n\r\n•  Hiệu năng hàng đầu - Chip Apple M2, 8 nhân GPU, hỗ trợ tốt các phần mềm như Word, Axel, Adobe Premier\r\n\r\n•  Đa nhiệm mượt mà - Ram 8GB, SSD 512GB cho phép vừa làm việc, vừa nghe nhạc\r\n\r\n•  Màn hình sắc nét - Độ phân giải 2560 x 1664 cùng độ sáng 500 nits\r\n\r\n•  Âm thanh sống động - 4 loa trang bị công nghệ dolby atmos và âm thanh đa chiều\r\n";
            label3.Text = "AppleCare+ cho máy Mac\r\n\r\nMọi máy Mac đều được bảo hành một năm và hỗ trợ kỹ thuật miễn phí lên đến 90 ngày. \r\n\r\nAppleCare+ cho Mac mở rộng phạm vi bảo hành của bạn lên ba năm kể từ ngày mua AppleCare+ và thêm các sự cố bảo vệ thiệt hại do tai nạn không giới hạn, mỗi trường hợp phải chịu phí dịch vụ $99 đối với hư hỏng màn hình hoặc thân máy hoặc $299 đối với các hư hỏng khác. \r\n\r\nNgoài ra, bạn sẽ được ưu tiên tiếp cận các chuyên gia của Apple 24/7 qua trò chuyện hoặc điện thoại thông qua getsupport.apple.com.\r\n";

        }

        private void pan_mac_picb_imac1_Click(object sender, EventArgs e)
        {
            pan_detail.Visible = true;
            pan_detial_picb_product.Image = Properties.Resources.mac_5;
            pan_detail_lab_name.Text = pan_mac_lab_mac5.Text;
            pan_detail_lab_price.Text = mac_5_price.Text;
            pan_detail_lab_promo.Text = "•  Giảm thêm 500.000đ khi thanh toán qua VNPAY\r\n•  Thu cũ lên đời - Trợ giá 1 triệu (Tuỳ model máy cũ, không áp dụng cùng ưu đãi cổng thanh toán)\r\n•  Voucher mua Office Home & Student 2021 chỉ còn 2,090,000\r\n";
            pan_detail_lab_policy.Text = "📦 Bộ sản phẩm gồm: Hộp, Cáp Type C to MagSafe, \r\nSách hướng dẫn, Adapter USB-C\r\n🔄 Bảo hành chính hãng 1 năm\r\n🚚 Miễn phí giao hàng\r\n";
            pan_detail_lab_feature.Text = "ĐẶC ĐIỂM NỔI BẬT\r\n\r\n•  Đáp ứng tốt các nhu cầu sử dụng cơ bản như giải trí, xem phim, làm việc văn phòng\r\n\r\n•  Màn hình đỉnh cao - Độ phân giải 4.5K cùng công nghệ TrueTone cho phép điều chỉnh độ sáng phù hợp với môi trường\r\n\r\n•  Thoải mái trò chuyện video call - Chất lượng webcam rõ ràng ngay cả trong điều kiện thiếu sáng\r\n\r\n•  Xem phim hay nghe nhạc tại nhà - Tích hợp 6 loa ngoài cùng công nghệ Dolby Atmos\r\n\r\n•  Phụ kiện đi kèm đầy đủ - Trang bị sẵn Magic Keyboard và Magic Mouse\r\n";
            label3.Text = "AppleCare+ cho máy Mac\r\n\r\nMọi máy Mac đều được bảo hành một năm và hỗ trợ kỹ thuật miễn phí lên đến 90 ngày. \r\n\r\nAppleCare+ cho Mac mở rộng phạm vi bảo hành của bạn lên ba năm kể từ ngày mua AppleCare+ và thêm các sự cố bảo vệ thiệt hại do tai nạn không giới hạn, mỗi trường hợp phải chịu phí dịch vụ $99 đối với hư hỏng màn hình hoặc thân máy hoặc $299 đối với các hư hỏng khác. \r\n\r\nNgoài ra, bạn sẽ được ưu tiên tiếp cận các chuyên gia của Apple 24/7 qua trò chuyện hoặc điện thoại thông qua getsupport.apple.com.\r\n";

        }

        private void pan_mac_picb_imac2_Click(object sender, EventArgs e)
        {
            pan_detail.Visible = true;
            pan_detial_picb_product.Image = Properties.Resources.mac_6;
            pan_detail_lab_name.Text = pan_mac_lab_mac6.Text;
            pan_detail_lab_price.Text = mac_6_price.Text;
            pan_detail_lab_promo.Text = "•  Giảm thêm 500.000đ khi thanh toán qua VNPAY\r\n•  Thu cũ lên đời - Trợ giá 1 triệu (Tuỳ model máy cũ, không áp dụng cùng ưu đãi cổng thanh toán)\r\n•  Voucher mua Office Home & Student 2021 chỉ còn 2,090,000\r\n";
            pan_detail_lab_policy.Text = "📦 Bộ sản phẩm gồm: Hộp, Cáp Type C to MagSafe, \r\nSách hướng dẫn, Adapter USB-C\r\n🔄 Bảo hành chính hãng 1 năm\r\n🚚 Miễn phí giao hàng\r\n";
            pan_detail_lab_feature.Text = "ĐẶC ĐIỂM NỔI BẬT\r\n\r\n•  Đáp ứng tốt các nhu cầu sử dụng cơ bản như giải trí, xem phim, làm việc văn phòng\r\n\r\n•  Màn hình đỉnh cao - Độ phân giải 4.5K cùng công nghệ TrueTone cho phép điều chỉnh độ sáng phù hợp với môi trường\r\n\r\n•  Thoải mái trò chuyện video call - Chất lượng webcam rõ ràng ngay cả trong điều kiện thiếu sáng\r\n\r\n•  Xem phim hay nghe nhạc tại nhà - Tích hợp 6 loa ngoài cùng công nghệ Dolby Atmos\r\n\r\n•  Phụ kiện đi kèm đầy đủ - Trang bị sẵn Magic Keyboard và Magic Mouse\r\n";
            label3.Text = "AppleCare+ cho máy Mac\r\n\r\nMọi máy Mac đều được bảo hành một năm và hỗ trợ kỹ thuật miễn phí lên đến 90 ngày. \r\n\r\nAppleCare+ cho Mac mở rộng phạm vi bảo hành của bạn lên ba năm kể từ ngày mua AppleCare+ và thêm các sự cố bảo vệ thiệt hại do tai nạn không giới hạn, mỗi trường hợp phải chịu phí dịch vụ $99 đối với hư hỏng màn hình hoặc thân máy hoặc $299 đối với các hư hỏng khác. \r\n\r\nNgoài ra, bạn sẽ được ưu tiên tiếp cận các chuyên gia của Apple 24/7 qua trò chuyện hoặc điện thoại thông qua getsupport.apple.com.\r\n";

        }

        private void pan_ipad_picb_pro2_Click(object sender, EventArgs e)
        {
            pan_detail.Visible = true;
            pan_detial_picb_product.Image = Properties.Resources.ipad_2;
            pan_detail_lab_name.Text = pan_ipad_lab_pro2.Text;
            pan_detail_lab_price.Text = ipad_pro_2_price.Text;
            pan_detail_lab_promo.Text = "•  Giảm thêm 400.000đ khi thanh toán qua VNPAY khi mua sản phẩm iPad\r\n•  Thu cũ Đổi mới: Giảm đến 1.5 triệu (Tuỳ model máy cũ, không áp dụng cùng ưu đãi cổng thanh toán)\r\n•  Voucher giảm 100.000đ mua Microsoft Office\r\n";
            pan_detail_lab_policy.Text = "📦 Bộ sản phẩm gồm: Hộp, Sách hướng dẫn, Cây lấy sim, Cáp Type C to Type C, Adapter USB-C\r\n🔄 Bảo hành chính hãng 1 năm\r\n🚚 Miễn phí giao hàng\r\n";
            pan_detail_lab_feature.Text = "ĐẶC ĐIỂM NỔI BẬT\r\n\r\n•  Đáp ứng tốt các nhu cầu sử dụng cơ bản như giải trí, xem phim, làm việc văn phòng\r\n\r\n•  Màn hình đỉnh cao - Độ phân giải 4.5K cùng công nghệ TrueTone cho phép điều chỉnh độ sáng phù hợp với môi trường\r\n\r\n•  Thoải mái trò chuyện video call - Chất lượng webcam rõ ràng ngay cả trong điều kiện thiếu sáng\r\n\r\n•  Xem phim hay nghe nhạc tại nhà - Tích hợp 6 loa ngoài cùng công nghệ Dolby Atmos\r\n\r\n•  Phụ kiện đi kèm đầy đủ - Trang bị sẵn Magic Keyboard và Magic Mouse\r\n";
            label3.Text = "AppleCare+\r\n\r\nMỗi iPad đều đi kèm với một năm bảo hành sửa chữa phần cứng thông qua chế độ bảo hành và hỗ trợ kỹ thuật miễn phí lên tới 90 ngày.\r\n\r\nAppleCare+ mở rộng phạm vi bảo hiểm bàn phím iPad, Apple Pencil và iPad mang nhãn hiệu Apple của bạn và bao gồm các sự cố bảo vệ thiệt hại do tai nạn không giới hạn. \r\nMỗi sự cố đều phải chịu phí dịch vụ $49 cho iPad và $29 cho Apple Pencil hoặc bàn phím iPad nhãn hiệu Apple (chưa bao gồm thuế).\r\n\r\nNgoài ra, bạn sẽ được ưu tiên tiếp cận các chuyên gia của Apple 24/7 qua trò chuyện hoặc điện thoại. \r\n";

        }

        private void pan_ipad_picb_air5_Click(object sender, EventArgs e)
        {
            pan_detail.Visible = true;
            pan_detial_picb_product.Image = Properties.Resources.ipad_3;
            pan_detail_lab_name.Text = pan_ipad_lab_air1.Text;
            pan_detail_lab_price.Text = ipad_air_1_price.Text;
            pan_detail_lab_promo.Text = "•  Giảm thêm 400.000đ khi thanh toán qua VNPAY khi mua sản phẩm iPad\r\n•  Thu cũ Đổi mới: Giảm đến 1.5 triệu (Tuỳ model máy cũ, không áp dụng cùng ưu đãi cổng thanh toán)\r\n•  Voucher giảm 100.000đ mua Microsoft Office\r\n";
            pan_detail_lab_policy.Text = "📦 Bộ sản phẩm gồm: Hộp, Sách hướng dẫn, Cây lấy sim, Cáp Type C to Type C, Adapter USB-C\r\n🔄 Bảo hành chính hãng 1 năm\r\n🚚 Miễn phí giao hàng\r\n";
            pan_detail_lab_feature.Text = "ĐẶC ĐIỂM NỔI BẬT\r\n\r\n•  Đáp ứng tốt các nhu cầu sử dụng cơ bản như giải trí, xem phim, làm việc văn phòng\r\n\r\n•  Màn hình đỉnh cao - Độ phân giải 4.5K cùng công nghệ TrueTone cho phép điều chỉnh độ sáng phù hợp với môi trường\r\n\r\n•  Thoải mái trò chuyện video call - Chất lượng webcam rõ ràng ngay cả trong điều kiện thiếu sáng\r\n\r\n•  Xem phim hay nghe nhạc tại nhà - Tích hợp 6 loa ngoài cùng công nghệ Dolby Atmos\r\n\r\n•  Phụ kiện đi kèm đầy đủ - Trang bị sẵn Magic Keyboard và Magic Mouse\r\n";
            label3.Text = "AppleCare+\r\n\r\nMỗi iPad đều đi kèm với một năm bảo hành sửa chữa phần cứng thông qua chế độ bảo hành và hỗ trợ kỹ thuật miễn phí lên tới 90 ngày.\r\n\r\nAppleCare+ mở rộng phạm vi bảo hiểm bàn phím iPad, Apple Pencil và iPad mang nhãn hiệu Apple của bạn và bao gồm các sự cố bảo vệ thiệt hại do tai nạn không giới hạn. \r\nMỗi sự cố đều phải chịu phí dịch vụ $49 cho iPad và $29 cho Apple Pencil hoặc bàn phím iPad nhãn hiệu Apple (chưa bao gồm thuế).\r\n\r\nNgoài ra, bạn sẽ được ưu tiên tiếp cận các chuyên gia của Apple 24/7 qua trò chuyện hoặc điện thoại. \r\n";
        }

        private void pan_iphone_lab_ip14pro_Click(object sender, EventArgs e)
        {
            //pan_iphone_picb_14promax.Image = Properties.Resources.box_ip14pm;
            //pan_iphone_lab_14pm.Text = "iPhone 14 Pro Max";
            //iphone_14promax_price.Text = "39.990.000";

            //pan_iphone_picb_14pro.Image = Properties.Resources.box_ip14pro;
            //pan_iphone_lab_14pro.Text = "iPhone 14 Pro";
            //iphone_14pro_price.Text = "30.490.000";


            pan_iphone_picb_14plus.Visible = false;
            pan_iphone_lab_14plus.Visible = false;

            pan_iphone_picb_14.Visible = false;
            pan_iphone_lab_14.Visible = false;

            pan_iphone_picb_13.Visible = false;
            pan_iphone_lab_13.Visible = false;

            pan_iphone_picb_13mini.Visible = false;
            pan_iphone_lab_13mini.Visible = false;

            iphone_14plus_price.Visible = false;
            iphone_14_price.Visible = false;
            iphone_13mini_price.Visible = false;
            iphone_13_price.Visible = false;

            //pan_iphone_picb_14promax.Location = new Point(220, 550);
            //pan_iphone_lab_14pm.Location = new Point(220, 930);
            //iphone_14promax_price.Location = new Point(352, 980);

            //pan_iphone_picb_14pro.Location = new Point(636, 550);
            //pan_iphone_lab_14pro.Location = new Point(636, 930);
            //iphone_14pro_price.Location = new Point(768, 980);

            pan_iphone_picb_14promax.Visible = true;
            pan_iphone_lab_14pm.Visible = true;

            pan_iphone_picb_14pro.Visible = true;
            pan_iphone_lab_14pro.Visible = true;

            iphone_14promax_price.Visible = true;
            iphone_14pro_price.Visible = true;

        }

        private void pan_iphone_lab_all_Click(object sender, EventArgs e)
        {

            pan_iphone_picb_14promax.Visible = true;
            pan_iphone_lab_14pm.Visible = true;

            pan_iphone_picb_14pro.Visible = true;
            pan_iphone_lab_14pro.Visible = true;

            pan_iphone_picb_14plus.Visible = true;
            pan_iphone_lab_14plus.Visible = true;

            pan_iphone_picb_14.Visible = true;
            pan_iphone_lab_14.Visible = true;

            pan_iphone_picb_13.Visible = true;
            pan_iphone_lab_13.Visible = true;

            pan_iphone_picb_13mini.Visible = true;
            pan_iphone_lab_13mini.Visible = true;

            iphone_14promax_price.Visible = true;
            iphone_14pro_price.Visible = true;
            iphone_14plus_price.Visible = true;
            iphone_14_price.Visible = true;
            iphone_13mini_price.Visible = true;
            iphone_13_price.Visible = true;


            pan_iphone_picb_14plus.Location = new Point(pan_iphone_picb_14promax.Location.X+832, pan_iphone_picb_14promax.Location.Y);
            pan_iphone_lab_14plus.Location = new Point(pan_iphone_picb_14plus.Location.X, pan_iphone_picb_14plus.Location.Y+380);
            iphone_14plus_price.Location = new Point(pan_iphone_picb_14plus.Location.X + 132, pan_iphone_picb_14plus.Location.Y + 430);

            pan_iphone_picb_14.Location = new Point(pan_iphone_picb_14promax.Location.X, pan_iphone_picb_14promax.Location.Y + 530);
            pan_iphone_lab_14.Location = new Point(pan_iphone_picb_14.Location.X, pan_iphone_picb_14.Location.Y + 380);
            iphone_14_price.Location = new Point(pan_iphone_picb_14.Location.X + 132, pan_iphone_picb_14.Location.Y + 430);

            //new Point(pan_iphone_picb_14promax.Location.X, pan_iphone_picb_14promax.Location.Y + 530);
            //new Point(pan_iphone_picb_14.Location.X, pan_iphone_picb_14.Location.Y + 380);
            //new Point(pan_iphone_picb_14.Location.X + 132, pan_iphone_picb_14.Location.Y + 430);

            pan_iphone_picb_13.Location = new Point(pan_iphone_picb_14promax.Location.X + 416, pan_iphone_picb_14promax.Location.Y + 530);
            pan_iphone_lab_13.Location = new Point(pan_iphone_picb_13.Location.X, pan_iphone_picb_13.Location.Y + 380);
            iphone_13_price.Location = new Point(pan_iphone_picb_13.Location.X + 132, pan_iphone_picb_13.Location.Y + 430);

            pan_iphone_picb_13mini.Location = new Point(pan_iphone_picb_14promax.Location.X + 832, pan_iphone_picb_14promax.Location.Y + 530);
            pan_iphone_lab_13mini.Location = new Point(pan_iphone_picb_13mini.Location.X, pan_iphone_picb_13mini.Location.Y + 380);
            iphone_13mini_price.Location = new Point(pan_iphone_picb_13mini.Location.X + 132, pan_iphone_picb_13mini.Location.Y + 430);




        }

        private void pan_iphone_lab_ip14_Click(object sender, EventArgs e)
        {
            pan_iphone_picb_14promax.Visible = false;
            pan_iphone_lab_14pm.Visible = false;

            pan_iphone_picb_14pro.Visible = false;
            pan_iphone_lab_14pro.Visible = false;

            pan_iphone_picb_13.Visible = false;
            pan_iphone_lab_13.Visible = false;

            pan_iphone_picb_13mini.Visible = false;
            pan_iphone_lab_13mini.Visible = false;

            iphone_14promax_price.Visible = false;
            iphone_14pro_price.Visible = false;
            iphone_13mini_price.Visible = false;
            iphone_13_price.Visible = false;

            //pan_iphone_picb_14pro.Image = Properties.Resources.box_ip14pro;
            //pan_iphone_lab_14pro.Text = "iPhone 14 Pro";
            //iphone_14pro_price.Text = "30.490.000";

            pan_iphone_picb_14plus.Visible = true;
            pan_iphone_lab_14plus.Visible= true;


            pan_iphone_picb_14.Visible = true;
            pan_iphone_lab_14.Visible = true;

            iphone_14plus_price.Visible = true;
            iphone_14_price.Visible = true;

            pan_iphone_picb_14plus.Location = new Point(pan_iphone_picb_14promax.Location.X, pan_iphone_picb_14promax.Location.Y);
            pan_iphone_lab_14plus.Location = new Point(pan_iphone_lab_14pm.Location.X, pan_iphone_lab_14pm.Location.Y);
            iphone_14plus_price.Location = new Point(iphone_14promax_price.Location.X, iphone_14promax_price.Location.Y);

            pan_iphone_picb_14.Location = new Point(pan_iphone_picb_14pro.Location.X, pan_iphone_picb_14pro.Location.Y);
            pan_iphone_lab_14.Location = new Point(pan_iphone_lab_14pro.Location.X, pan_iphone_lab_14pro.Location.Y);
            iphone_14_price.Location = new Point(iphone_14pro_price.Location.X, iphone_14pro_price.Location.Y);
        }

        private void pan_iphone_lab_ip13_Click(object sender, EventArgs e)
        {
            pan_iphone_picb_14promax.Visible = false;
            pan_iphone_lab_14pm.Visible = false;

            pan_iphone_picb_14pro.Visible = false;
            pan_iphone_lab_14pro.Visible = false;

            pan_iphone_picb_13.Visible = true;
            pan_iphone_lab_13.Visible = true;

            pan_iphone_picb_13mini.Visible = true;
            pan_iphone_lab_13mini.Visible = true;

            iphone_14promax_price.Visible = false;
            iphone_14pro_price.Visible = false;

            iphone_13mini_price.Visible = true;
            iphone_13_price.Visible = true;


            pan_iphone_picb_14plus.Visible = false;
            pan_iphone_lab_14plus.Visible = false;


            pan_iphone_picb_14.Visible = false;
            pan_iphone_lab_14.Visible = false;

            iphone_14plus_price.Visible = false;
            iphone_14_price.Visible = false;

            pan_iphone_picb_13.Location = new Point(pan_iphone_picb_14promax.Location.X, pan_iphone_picb_14promax.Location.Y);
            pan_iphone_lab_13.Location = new Point(pan_iphone_lab_14pm.Location.X, pan_iphone_lab_14pm.Location.Y);
            iphone_13_price.Location = new Point(iphone_14promax_price.Location.X, iphone_14promax_price.Location.Y);

            pan_iphone_picb_13mini.Location = new Point(pan_iphone_picb_14pro.Location.X, pan_iphone_picb_14pro.Location.Y);
            pan_iphone_lab_13mini.Location = new Point(pan_iphone_lab_14pro.Location.X, pan_iphone_lab_14pro.Location.Y);
            iphone_13mini_price.Location = new Point(iphone_14pro_price.Location.X, iphone_14pro_price.Location.Y);
        }

        private void pan_mac_lab_all_Click(object sender, EventArgs e)
        {
            pan_mac_picb_mac1.Visible = true;
            pan_mac_lab_mac1.Visible = true;
            mac_1_price.Visible = true;

            pan_mac_lab_mac2.Visible = true;
            pan_mac_picb_mac2.Visible = true;
            mac_2_price.Visible = true;

            pan_mac_lab_mac3.Visible = true;
            pan_mac_picb_mac3.Visible = true;
            mac_3_price.Visible = true;

            pan_mac_lab_mac4.Visible = true;
            pan_mac_picb_mac4.Visible = true;
            mac_4_price.Visible = true;

            pan_mac_lab_mac5.Visible = true;
            pan_mac_picb_mac5.Visible = true;
            mac_5_price.Visible = true;

            pan_mac_lab_mac6.Visible = true;
            pan_mac_picb_mac6.Visible = true;
            mac_6_price.Visible = true;

            pan_mac_picb_mac3.Location = new Point(pan_mac_picb_mac1.Location.X+832, pan_mac_picb_mac1.Location.Y);
            pan_mac_lab_mac3.Location = new Point(pan_mac_picb_mac3.Location.X , pan_mac_picb_mac3.Location.Y + 380);
            mac_3_price.Location= new Point(pan_mac_picb_mac3.Location.X + 132, pan_mac_picb_mac3.Location.Y + 430);

            pan_mac_picb_mac4.Location = new Point(pan_mac_picb_mac1.Location.X, pan_mac_picb_mac1.Location.Y+530);
            pan_mac_lab_mac4.Location = new Point(pan_mac_picb_mac4.Location.X, pan_mac_picb_mac4.Location.Y + 380);
            mac_4_price.Location = new Point(pan_mac_picb_mac4.Location.X + 132, pan_mac_picb_mac4.Location.Y + 430);

            pan_mac_picb_mac5.Location = new Point(pan_mac_picb_mac1.Location.X+416, pan_mac_picb_mac1.Location.Y + 530);
            pan_mac_lab_mac5.Location = new Point(pan_mac_picb_mac5.Location.X, pan_mac_picb_mac5.Location.Y + 380);
            mac_5_price.Location = new Point(pan_mac_picb_mac5.Location.X + 132, pan_mac_picb_mac5.Location.Y + 430);

            pan_mac_picb_mac6.Location = new Point(pan_mac_picb_mac1.Location.X + 832, pan_mac_picb_mac1.Location.Y + 530);
            pan_mac_lab_mac6.Location = new Point(pan_mac_picb_mac6.Location.X, pan_mac_picb_mac6.Location.Y + 380);
            mac_6_price.Location = new Point(pan_mac_picb_mac6.Location.X + 132, pan_mac_picb_mac6.Location.Y + 430);
        }

        private void pan_mac_lab_pro_Click(object sender, EventArgs e)
        {
            pan_mac_picb_mac1.Visible = true;
            pan_mac_lab_mac1.Visible = true;
            mac_1_price.Visible = true;

            pan_mac_lab_mac2.Visible = true;
            pan_mac_picb_mac2.Visible = true;
            mac_2_price.Visible = true;

            pan_mac_lab_mac3.Visible = false;
            pan_mac_picb_mac3.Visible = false;
            mac_3_price.Visible = false;

            pan_mac_lab_mac4.Visible = false;
            pan_mac_picb_mac4.Visible = false;
            mac_4_price.Visible = false;

            pan_mac_lab_mac5.Visible = false;
            pan_mac_picb_mac5.Visible = false;
            mac_5_price.Visible = false;

            pan_mac_lab_mac6.Visible = false;
            pan_mac_picb_mac6.Visible = false;
            mac_6_price.Visible = false;

        }

        private void pan_mac_lab_air_Click(object sender, EventArgs e)
        {

            pan_mac_lab_mac3.Visible = true;
            pan_mac_picb_mac3.Visible = true;
            mac_3_price.Visible = true;

            pan_mac_lab_mac4.Visible = true;
            pan_mac_picb_mac4.Visible = true;
            mac_4_price.Visible = true;

            pan_mac_picb_mac1.Visible = false;
            pan_mac_lab_mac1.Visible = false;
            mac_1_price.Visible = false;

            pan_mac_lab_mac2.Visible = false;
            pan_mac_picb_mac2.Visible = false;
            mac_2_price.Visible = false;



            pan_mac_lab_mac5.Visible = false;
            pan_mac_picb_mac5.Visible = false;
            mac_5_price.Visible = false;

            pan_mac_lab_mac6.Visible = false;
            pan_mac_picb_mac6.Visible = false;
            mac_6_price.Visible = false;

            pan_mac_picb_mac3.Location = new Point(pan_mac_picb_mac1.Location.X, pan_mac_picb_mac1.Location.Y);
            pan_mac_lab_mac3.Location = new Point(pan_mac_picb_mac3.Location.X, pan_mac_picb_mac3.Location.Y + 380);
            mac_3_price.Location = new Point(pan_mac_picb_mac3.Location.X + 132, pan_mac_picb_mac3.Location.Y + 430);

            pan_mac_picb_mac4.Location = new Point(pan_mac_picb_mac2.Location.X, pan_mac_picb_mac2.Location.Y);
            pan_mac_lab_mac4.Location = new Point(pan_mac_picb_mac4.Location.X, pan_mac_picb_mac4.Location.Y + 380);
            mac_4_price.Location = new Point(pan_mac_picb_mac4.Location.X + 132, pan_mac_picb_mac4.Location.Y + 430);

        }

        private void pan_mac_lab_imac_Click(object sender, EventArgs e)
        {
            pan_mac_picb_mac1.Visible = false;
            pan_mac_lab_mac1.Visible = false;
            mac_1_price.Visible = false;

            pan_mac_lab_mac2.Visible = false;
            pan_mac_picb_mac2.Visible = false;
            mac_2_price.Visible = false;

            pan_mac_lab_mac3.Visible = false;
            pan_mac_picb_mac3.Visible = false;
            mac_3_price.Visible = false;

            pan_mac_lab_mac4.Visible = false;
            pan_mac_picb_mac4.Visible = false;
            mac_4_price.Visible = false;

            pan_mac_lab_mac5.Visible = true;
            pan_mac_picb_mac5.Visible = true;
            mac_5_price.Visible = true;

            pan_mac_lab_mac6.Visible = true;
            pan_mac_picb_mac6.Visible = true;
            mac_6_price.Visible = true;

            pan_mac_picb_mac5.Location = new Point(pan_mac_picb_mac1.Location.X, pan_mac_picb_mac1.Location.Y);
            pan_mac_lab_mac5.Location = new Point(pan_mac_picb_mac5.Location.X, pan_mac_picb_mac5.Location.Y + 380);
            mac_5_price.Location = new Point(pan_mac_picb_mac5.Location.X + 132, pan_mac_picb_mac5.Location.Y + 430);

            pan_mac_picb_mac6.Location = new Point(pan_mac_picb_mac2.Location.X, pan_mac_picb_mac2.Location.Y);
            pan_mac_lab_mac6.Location = new Point(pan_mac_picb_mac6.Location.X, pan_mac_picb_mac6.Location.Y + 380);
            mac_6_price.Location = new Point(pan_mac_picb_mac6.Location.X + 132, pan_mac_picb_mac6.Location.Y + 430);
        }

        private void pan_acs_picb_watch_1_Click(object sender, EventArgs e)
        {
            pan_detail.Visible = true;
            pan_detial_picb_product.Image = Properties.Resources.acs_1;
            pan_detail_lab_name.Text = pan_acs_lab_watch_1.Text;
            pan_detail_lab_price.Text = watch_1_price.Text;
            pan_detail_lab_promo.Text = "•  Giảm 300.000đ khi thanh toán qua VNPAY khi mua sản phẩm Apple Watch\r\n•  Thu cũ Đổi mới: Trợ giá lên đến 1 triệu (Tuỳ model, không áp dụng cùng ưu đãi cổng thanh toán)\r\n•  Giảm thêm tới 800.000đ khi mở thẻ TP Bank EVO thành công (Không áp dụng đồng thời KM khác)\r\n";
            pan_detail_lab_policy.Text = "📦 Bộ sản phẩm gồm: Hộp, Đế sạc nhanh nam châm,  Sách hướng dẫn, Đồng hồ\r\n🔄 Bảo hành chính hãng 1 năm\r\n🚚 Miễn phí giao hàng\r\n";
            label3.Text = "🌱 Mục tiêu môi trường của chúng tôi.\r\n\r\n    Là một phần trong nỗ lực giảm tác động đến môi trường của chúng tôi, Apple Watch không bao gồm bộ sạc trong hộp sản phẩm. Vui lòng sử dụng bộ đổi nguồn Apple hiện có của bạn hoặc thêm bộ sạc trước khi bạn thanh toán.\r\n\r\n    Apple Watch chỉ tương thích iPhone 8 trở lên với iOS 16 trở lên.\r\n";
            pan_detail_lab_feature.Text = "ĐẶC ĐIỂM NỔI BẬT\r\n\r\n•  Bền bỉ trước mọi thử thách - Khung viền titan, mặt kính Sapphire mang lại độ bền chuẩn quân đội MIL-STD 810H\r\n\r\n•  Trợ lý sức khoẻ 24/24 - Cảm biến nhịp tim, cảm biến nhiệt, nhận diện va chạm xe\r\n\r\n•  Tập luyện chuyên nghiệp - Tích hợp nhiều chế độ thể thao đo như lặn, bơi, đạp xe\r\n\r\n•  Lặn sâu đến 40m, chống bụi xâm nhập - Đạt chứng nhận EN13319, IPX6\r\n\r\n•  Pin lên đến 36 giờ khi sử dụng thông thường, 60 giờ ở chế độ tiết kiệm pin\r\n";
        }



        private void pan_acs_lab_all_Click(object sender, EventArgs e)
        {
            //Watch
            pan_acs_picb_watch_1.Visible = true;
            pan_acs_lab_watch_1.Visible = true;
            watch_1_price.Visible = true;

            pan_acs_picb_watch_2.Visible = true;
            pan_acs_lab_watch_2.Visible = true;
            watch_2_price.Visible = true;

            pan_acs_picb_watch_3.Visible = true;
            pan_acs_lab_watch_3.Visible = true;
            watch_3_price.Visible = true;

            pan_acs_picb_watch_4.Visible = true;
            pan_acs_lab_watch_4.Visible = true;
            watch_4_price.Visible = true;

            pan_acs_picb_watch_5.Visible = true;
            pan_acs_lab_watch_5.Visible = true;
            watch_5_price.Visible = true;

            pan_acs_picb_watch_6.Visible = true;
            pan_acs_lab_watch_6.Visible = true;
            watch_6_price.Visible = true;

            //airpods

            pan_acs_picb_ap_1.Visible = true;
            pan_acs_lab_ap_1.Visible = true;
            airpods_1_price.Visible = true;

            pan_acs_picb_ap_2.Visible = true;
            pan_acs_lab_ap_2.Visible = true;
            airpods_2_price.Visible = true;

            pan_acs_picb_ap_3.Visible = true;
            pan_acs_lab_ap_3.Visible = true;
            airpods_3_price.Visible = true;

            pan_acs_picb_ap_4.Visible = true;
            pan_acs_lab_ap_4.Visible = true;
            airpods_4_price.Visible = true;

            pan_acs_picb_ap_5.Visible = true;
            pan_acs_lab_ap_5.Visible = true;
            airpods_5_price.Visible = true;

            pan_acs_picb_ap_6.Visible = true;
            pan_acs_lab_ap_6.Visible = true;
            airpods_6_price.Visible = true;

            //other

            pan_acs_picb_other_1.Visible = true;
            pan_acs_lab_other_1.Visible = true;
            other1_price.Visible = true;

            pan_acs_picb_other_2.Visible = true;
            pan_acs_lab_other_2.Visible = true;
            other2_price.Visible = true;

            pan_acs_picb_ap_1.Location = new Point(pan_acs_picb_watch_4.Location.X, pan_acs_picb_watch_4.Location.Y + 530);
            pan_acs_lab_ap_1.Location = new Point(pan_acs_picb_ap_1.Location.X, pan_acs_picb_ap_1.Location.Y + 380);
            airpods_1_price.Location = new Point(pan_acs_picb_ap_1.Location.X + 132, pan_acs_picb_ap_1.Location.Y + 430);

            pan_acs_picb_ap_2.Location = new Point(pan_acs_picb_watch_4.Location.X + 416, pan_acs_picb_watch_4.Location.Y + 530);
            pan_acs_lab_ap_2.Location = new Point(pan_acs_picb_ap_2.Location.X, pan_acs_picb_ap_2.Location.Y + 380);
            airpods_2_price.Location = new Point(pan_acs_picb_ap_2.Location.X + 132, pan_acs_picb_ap_2.Location.Y + 430);

            pan_acs_picb_ap_3.Location = new Point(pan_acs_picb_watch_4.Location.X + 832, pan_acs_picb_watch_4.Location.Y + 530);
            pan_acs_lab_ap_3.Location = new Point(pan_acs_picb_ap_3.Location.X, pan_acs_picb_ap_3.Location.Y + 380);
            airpods_3_price.Location = new Point(pan_acs_picb_ap_3.Location.X + 132, pan_acs_picb_ap_3.Location.Y + 430);

            pan_acs_picb_ap_4.Location = new Point(pan_acs_picb_watch_4.Location.X, pan_acs_picb_watch_4.Location.Y + 1060);
            pan_acs_lab_ap_4.Location = new Point(pan_acs_picb_ap_4.Location.X, pan_acs_picb_ap_4.Location.Y + 380);
            airpods_4_price.Location = new Point(pan_acs_picb_ap_4.Location.X + 132, pan_acs_picb_ap_4.Location.Y + 430);

            pan_acs_picb_ap_5.Location = new Point(pan_acs_picb_watch_4.Location.X + 416, pan_acs_picb_watch_4.Location.Y + 1060);
            pan_acs_lab_ap_5.Location = new Point(pan_acs_picb_ap_5.Location.X, pan_acs_picb_ap_5.Location.Y + 380);
            airpods_5_price.Location = new Point(pan_acs_picb_ap_5.Location.X + 132, pan_acs_picb_ap_5.Location.Y + 430);

            pan_acs_picb_ap_6.Location = new Point(pan_acs_picb_watch_4.Location.X + 832, pan_acs_picb_watch_4.Location.Y + 1060);
            pan_acs_lab_ap_6.Location = new Point(pan_acs_picb_ap_6.Location.X, pan_acs_picb_ap_6.Location.Y + 380);
            airpods_6_price.Location = new Point(pan_acs_picb_ap_6.Location.X + 140, pan_acs_picb_ap_6.Location.Y + 430);

            pan_acs_picb_other_1.Location = new Point(pan_acs_picb_watch_4.Location.X, pan_acs_picb_watch_4.Location.Y + 1590);
            pan_acs_lab_other_1.Location = new Point(pan_acs_picb_other_1.Location.X, pan_acs_picb_other_1.Location.Y + 380);
            other1_price.Location = new Point(pan_acs_picb_other_1.Location.X + 140, pan_acs_picb_other_1.Location.Y + 430);

            pan_acs_picb_other_2.Location = new Point(pan_acs_picb_watch_4.Location.X + 416, pan_acs_picb_watch_4.Location.Y + 1590);
            pan_acs_lab_other_2.Location = new Point(pan_acs_picb_other_2.Location.X, pan_acs_picb_other_2.Location.Y + 380);
            other2_price.Location = new Point(pan_acs_picb_other_2.Location.X + 132, pan_acs_picb_other_2.Location.Y + 430);
        }

        private void pan_acs_lab_watch_Click(object sender, EventArgs e)
        {
            //Watch
            pan_acs_picb_watch_1.Visible = true;
            pan_acs_lab_watch_1.Visible = true;
            watch_1_price.Visible = true;

            pan_acs_picb_watch_2.Visible = true;
            pan_acs_lab_watch_2.Visible = true;
            watch_2_price.Visible = true;

            pan_acs_picb_watch_3.Visible = true;
            pan_acs_lab_watch_3.Visible = true;
            watch_3_price.Visible = true;

            pan_acs_picb_watch_4.Visible = true;
            pan_acs_lab_watch_4.Visible = true;
            watch_4_price.Visible = true;

            pan_acs_picb_watch_5.Visible = true;
            pan_acs_lab_watch_5.Visible = true;
            watch_5_price.Visible = true;

            pan_acs_picb_watch_6.Visible = true;
            pan_acs_lab_watch_6.Visible = true;
            watch_6_price.Visible = true;

            //airpods

            pan_acs_picb_ap_1.Visible = false;
            pan_acs_lab_ap_1.Visible = false;
            airpods_1_price.Visible = false;

            pan_acs_picb_ap_2.Visible = false;
            pan_acs_lab_ap_2.Visible = false;
            airpods_2_price.Visible = false;

            pan_acs_picb_ap_3.Visible = false;
            pan_acs_lab_ap_3.Visible = false;
            airpods_3_price.Visible = false;

            pan_acs_picb_ap_4.Visible = false;
            pan_acs_lab_ap_4.Visible = false;
            airpods_4_price.Visible = false;

            pan_acs_picb_ap_5.Visible = false;
            pan_acs_lab_ap_5.Visible = false;
            airpods_5_price.Visible = false;

            pan_acs_picb_ap_6.Visible = false;
            pan_acs_lab_ap_6.Visible = false;
            airpods_6_price.Visible = false;

            //other

            pan_acs_picb_other_1.Visible = false;
            pan_acs_lab_other_1.Visible = false;
            other1_price.Visible = false;

            pan_acs_picb_other_2.Visible = false;
            pan_acs_lab_other_2.Visible = false;
            other2_price.Visible = false;
        }

        private void pan_acs_lab_airpods_Click(object sender, EventArgs e)
        {
            //Watch
            pan_acs_picb_watch_1.Visible = false;
            pan_acs_lab_watch_1.Visible = false;
            watch_1_price.Visible = false;

            pan_acs_picb_watch_2.Visible = false;
            pan_acs_lab_watch_2.Visible = false;
            watch_2_price.Visible = false;

            pan_acs_picb_watch_3.Visible = false;
            pan_acs_lab_watch_3.Visible = false;
            watch_3_price.Visible = false;

            pan_acs_picb_watch_4.Visible = false;
            pan_acs_lab_watch_4.Visible = false;
            watch_4_price.Visible = false;

            pan_acs_picb_watch_5.Visible = false;
            pan_acs_lab_watch_5.Visible = false;
            watch_5_price.Visible = false;

            pan_acs_picb_watch_6.Visible = false;
            pan_acs_lab_watch_6.Visible = false;
            watch_6_price.Visible = false;

            //airpods

            pan_acs_picb_ap_1.Visible = true;
            pan_acs_lab_ap_1.Visible = true;
            airpods_1_price.Visible = true;

            pan_acs_picb_ap_2.Visible = true;
            pan_acs_lab_ap_2.Visible = true;
            airpods_2_price.Visible = true;

            pan_acs_picb_ap_3.Visible = true;
            pan_acs_lab_ap_3.Visible = true;
            airpods_3_price.Visible = true;

            pan_acs_picb_ap_4.Visible = true;
            pan_acs_lab_ap_4.Visible = true;
            airpods_4_price.Visible = true;

            pan_acs_picb_ap_5.Visible = true;
            pan_acs_lab_ap_5.Visible = true;
            airpods_5_price.Visible = true;

            pan_acs_picb_ap_6.Visible = true;
            pan_acs_lab_ap_6.Visible = true;
            airpods_6_price.Visible = true;

            //other

            pan_acs_picb_other_1.Visible = false;
            pan_acs_lab_other_1.Visible = false;
            other1_price.Visible = false;

            pan_acs_picb_other_2.Visible = false;
            pan_acs_lab_other_2.Visible = false;
            other2_price.Visible = false;

            pan_acs_picb_ap_1.Location = new Point(pan_acs_picb_watch_1.Location.X, pan_acs_picb_watch_1.Location.Y);
            pan_acs_lab_ap_1.Location = new Point(pan_acs_picb_ap_1.Location.X, pan_acs_picb_ap_1.Location.Y + 380);
            airpods_1_price.Location = new Point(pan_acs_picb_ap_1.Location.X + 132, pan_acs_picb_ap_1.Location.Y + 430);

            pan_acs_picb_ap_2.Location = new Point(pan_acs_picb_watch_2.Location.X, pan_acs_picb_watch_2.Location.Y);
            pan_acs_lab_ap_2.Location = new Point(pan_acs_picb_ap_2.Location.X, pan_acs_picb_ap_2.Location.Y + 380);
            airpods_2_price.Location = new Point(pan_acs_picb_ap_2.Location.X + 132, pan_acs_picb_ap_2.Location.Y + 430);

            pan_acs_picb_ap_3.Location = new Point(pan_acs_picb_watch_3.Location.X, pan_acs_picb_watch_3.Location.Y);
            pan_acs_lab_ap_3.Location = new Point(pan_acs_picb_ap_3.Location.X, pan_acs_picb_ap_3.Location.Y + 380);
            airpods_3_price.Location = new Point(pan_acs_picb_ap_3.Location.X + 132, pan_acs_picb_ap_3.Location.Y + 430);

            pan_acs_picb_ap_4.Location = new Point(pan_acs_picb_watch_4.Location.X, pan_acs_picb_watch_4.Location.Y);
            pan_acs_lab_ap_4.Location = new Point(pan_acs_picb_ap_4.Location.X, pan_acs_picb_ap_4.Location.Y + 380);
            airpods_4_price.Location = new Point(pan_acs_picb_ap_4.Location.X + 132, pan_acs_picb_ap_4.Location.Y + 430);

            pan_acs_picb_ap_5.Location = new Point(pan_acs_picb_watch_5.Location.X, pan_acs_picb_watch_5.Location.Y);
            pan_acs_lab_ap_5.Location = new Point(pan_acs_picb_ap_5.Location.X, pan_acs_picb_ap_5.Location.Y + 380);
            airpods_5_price.Location = new Point(pan_acs_picb_ap_5.Location.X + 132, pan_acs_picb_ap_5.Location.Y + 430);

            pan_acs_picb_ap_6.Location = new Point(pan_acs_picb_watch_6.Location.X, pan_acs_picb_watch_6.Location.Y);
            pan_acs_lab_ap_6.Location = new Point(pan_acs_picb_ap_6.Location.X, pan_acs_picb_ap_6.Location.Y + 380);
            airpods_6_price.Location = new Point(pan_acs_picb_ap_6.Location.X + 140, pan_acs_picb_ap_6.Location.Y + 430);
        }

        private void pan_acs_lab_other_Click(object sender, EventArgs e)
        {
            pan_acs_picb_watch_1.Visible = false;
            pan_acs_lab_watch_1.Visible = false;
            watch_1_price.Visible = false;

            pan_acs_picb_watch_2.Visible = false;
            pan_acs_lab_watch_2.Visible = false;
            watch_2_price.Visible = false;

            pan_acs_picb_watch_3.Visible = false;
            pan_acs_lab_watch_3.Visible = false;
            watch_3_price.Visible = false;

            pan_acs_picb_watch_4.Visible = false;
            pan_acs_lab_watch_4.Visible = false;
            watch_4_price.Visible = false;

            pan_acs_picb_watch_5.Visible = false;
            pan_acs_lab_watch_5.Visible = false;
            watch_5_price.Visible = false;

            pan_acs_picb_watch_6.Visible = false;
            pan_acs_lab_watch_6.Visible = false;
            watch_6_price.Visible = false;

            //airpods

            pan_acs_picb_ap_1.Visible = false;
            pan_acs_lab_ap_1.Visible = false;
            airpods_1_price.Visible = false;

            pan_acs_picb_ap_2.Visible = false;
            pan_acs_lab_ap_2.Visible = false;
            airpods_2_price.Visible = false;

            pan_acs_picb_ap_3.Visible = false;
            pan_acs_lab_ap_3.Visible = false;
            airpods_3_price.Visible = false;

            pan_acs_picb_ap_4.Visible = false;
            pan_acs_lab_ap_4.Visible = false;
            airpods_4_price.Visible = false;

            pan_acs_picb_ap_5.Visible = false;
            pan_acs_lab_ap_5.Visible = false;
            airpods_5_price.Visible = false;

            pan_acs_picb_ap_6.Visible = false;
            pan_acs_lab_ap_6.Visible = false;
            airpods_6_price.Visible = false;

            //other

            pan_acs_picb_other_1.Visible = true;
            pan_acs_lab_other_1.Visible = true;
            other1_price.Visible = true;

            pan_acs_picb_other_2.Visible = true;
            pan_acs_lab_other_2.Visible = true;
            other2_price.Visible = true;

            pan_acs_picb_other_1.Location = new Point(pan_acs_picb_watch_1.Location.X, pan_acs_picb_watch_1.Location.Y);
            pan_acs_lab_other_1.Location = new Point(pan_acs_picb_other_1.Location.X, pan_acs_picb_other_1.Location.Y + 380);
            other1_price.Location = new Point(pan_acs_picb_other_1.Location.X + 140, pan_acs_picb_other_1.Location.Y + 430);

            pan_acs_picb_other_2.Location = new Point(pan_acs_picb_watch_2.Location.X, pan_acs_picb_watch_2.Location.Y);
            pan_acs_lab_other_2.Location = new Point(pan_acs_picb_other_2.Location.X, pan_acs_picb_other_2.Location.Y + 380);
            other2_price.Location = new Point(pan_acs_picb_other_2.Location.X + 132, pan_acs_picb_other_2.Location.Y + 430);

        }

        private void pan_acs_picb_watch_2_Click(object sender, EventArgs e)
        {
            pan_detail.Visible = true;
            pan_detial_picb_product.Image = Properties.Resources.acs_2;
            pan_detail_lab_name.Text = pan_acs_lab_watch_2.Text;
            pan_detail_lab_price.Text = watch_2_price.Text;
            pan_detail_lab_promo.Text = "•  Giảm 300.000đ khi thanh toán qua VNPAY khi mua sản phẩm Apple Watch\r\n•  Thu cũ Đổi mới: Trợ giá lên đến 1 triệu (Tuỳ model, không áp dụng cùng ưu đãi cổng thanh toán)\r\n•  Giảm thêm tới 800.000đ khi mở thẻ TP Bank EVO thành công (Không áp dụng đồng thời KM khác)\r\n";
            pan_detail_lab_policy.Text = "📦 Bộ sản phẩm gồm: Hộp, Đế sạc nhanh nam châm,  Sách hướng dẫn, Đồng hồ\r\n🔄 Bảo hành chính hãng 1 năm\r\n🚚 Miễn phí giao hàng\r\n";
            label3.Text = "🌱 Mục tiêu môi trường của chúng tôi.\r\n\r\n    Là một phần trong nỗ lực giảm tác động đến môi trường của chúng tôi, Apple Watch không bao gồm bộ sạc trong hộp sản phẩm. Vui lòng sử dụng bộ đổi nguồn Apple hiện có của bạn hoặc thêm bộ sạc trước khi bạn thanh toán.\r\n\r\n    Apple Watch chỉ tương thích iPhone 8 trở lên với iOS 16 trở lên.\r\n";
            pan_detail_lab_feature.Text = "ĐẶC ĐIỂM NỔI BẬT\r\n\r\n•  Kiểu dáng trẻ trung, hiện đại - Kính cường lực Ion-X, viền nhôm bền bỉ\r\n\r\n•  Siêu mượt mà - Trang bị Chip Apple S8 cùng hệ điều hành\r\n\r\n•  Tiện ích sức khoẻ đầy đủ - Đo điện tâm đồ, oxy trong máu, theo dõi giấc ngủ, mức độ stress...\r\n\r\n•  Nhiều chế độ tập luyện - Tính quãng đường chạy, đếm số bước chân, đạp xe, bơi lội, hỗ trợ kết nối với tai nghe bluetooth\r\n\r\n•  Ghi lại quãng đường tập luyện - Tích hợp 5 hệ thống định vị toàn cầu GPS, GLONASS, Galileo, QZSS, BDS\r\n\r\n•  Tính năng thông minh tiện lợi - Dự báo thời tiết, báo thức, trợ lý giọng nói\r\n\r\n•  Hỗ trợ Esim, thực hiện cuộc gọi ngay trên đồng hồ";
        }

        private void pan_acs_picb_ap_1_Click(object sender, EventArgs e)
        {
            pan_detail.Visible = true;
            pan_detial_picb_product.Image = Properties.Resources.acs_7;
            pan_detail_lab_name.Text = pan_acs_lab_ap_1.Text;
            pan_detail_lab_price.Text = airpods_1_price.Text;
            pan_detail_lab_promo.Text = "•  Giảm 300.000đ khi thanh toán qua VNPAY khi mua sản phẩm Airpods\r\n•  Thu cũ Đổi mới: Trợ giá lên đến 500.000 (Tuỳ model, không áp dụng cùng ưu đãi cổng thanh toán)\r\n•  Giảm thêm tới 800.000đ khi mở thẻ TP Bank EVO thành công (Không áp dụng đồng thời KM khác)\r\n";
            pan_detail_lab_policy.Text = "📦 Bộ sản phẩm gồm: Hộp, Cáp USB-C to Lightning,  Sách hướng dẫn, Nút tai thay thế, Case và tai nghe\r\n🔄 Bảo hành chính hãng 1 năm\r\n🚚 Miễn phí giao hàng\r\n";
            label3.Text = "AppleCare+ cho Tai nghe\r\n\r\nMỗi bộ AirPods, tai nghe Beats đều đi kèm với một năm bảo hành sửa chữa phần cứng và hỗ trợ kỹ thuật miễn phí lên đến 90 ngày.\r\n\r\nAppleCare+ mở rộng phạm vi bảo hiểm của bạn lên hai năm kể từ ngày mua AppleCare+ và bổ sung thêm các sự cố bảo vệ thiệt hại do tai nạn không giới hạn, mỗi sự cố đều phải trả phí dịch vụ $29, cộng với thuế hiện hành. \r\n\r\nNgoài ra, bạn sẽ được ưu tiên tiếp cận các chuyên gia của Apple 24/7 qua trò chuyện hoặc điện thoại.";
            pan_detail_lab_feature.Text = "ĐẶC ĐIỂM NỔI BẬT\r\n\r\n•  Tích hợp chip Apple H2 mang đến chất âm sống động cùng khả năng tái tạo âm thanh 3 chiều vượt trội\r\n\r\n•  Công nghệ Bluetooth 5.3 kết nối ổn định, mượt mà và tiêu thụ năng lượng thấp, giúp tiết kiệm pin đáng kể\r\n\r\n•  Chống ồn chủ động (ANC) hiệu quả gấp đôi thế hệ trước, loại bỏ tiếng ồn giúp nâng cao trải nghiệm nghe nhạc\r\n\r\n•  Chống nước chuẩn IPX4 trên cả tai nghe và hộp sạc, giúp bạn thỏa sức tập luyện không cần lo thấm mồ hôi\r\n\r\n•  Sử dụng thoải mái nhờ dung lượng pin lớn lên đến 30 tiếng khi kèm hộp sạc và sạc MagSafe nhanh chóng\r\n";
        }

        private void pan_acs_picb_ap_2_Click(object sender, EventArgs e)
        {
            pan_detail.Visible = true;
            pan_detial_picb_product.Image = Properties.Resources.acs_8;
            pan_detail_lab_name.Text = pan_acs_lab_ap_2.Text;
            pan_detail_lab_price.Text = airpods_2_price.Text;
            pan_detail_lab_promo.Text = "•  Giảm 300.000đ khi thanh toán qua VNPAY khi mua sản phẩm Airpods\r\n•  Thu cũ Đổi mới: Trợ giá lên đến 500.000 (Tuỳ model, không áp dụng cùng ưu đãi cổng thanh toán)\r\n•  Giảm thêm tới 800.000đ khi mở thẻ TP Bank EVO thành công (Không áp dụng đồng thời KM khác)\r\n";
            pan_detail_lab_policy.Text = "📦 Bộ sản phẩm gồm: Hộp, Cáp USB-C to Lightning, Nút tai thay thế,  Sách hướng dẫn, Case và tai nghe\r\n🔄 Bảo hành chính hãng 1 năm\r\n🚚 Miễn phí giao hàng\r\n";
            label3.Text = "AppleCare+ cho Tai nghe\r\n\r\nMỗi bộ AirPods, tai nghe Beats đều đi kèm với một năm bảo hành sửa chữa phần cứng và hỗ trợ kỹ thuật miễn phí lên đến 90 ngày.\r\n\r\nAppleCare+ mở rộng phạm vi bảo hiểm của bạn lên hai năm kể từ ngày mua AppleCare+ và bổ sung thêm các sự cố bảo vệ thiệt hại do tai nạn không giới hạn, mỗi sự cố đều phải trả phí dịch vụ $29, cộng với thuế hiện hành. \r\n\r\nNgoài ra, bạn sẽ được ưu tiên tiếp cận các chuyên gia của Apple 24/7 qua trò chuyện hoặc điện thoại.";
            pan_detail_lab_feature.Text = "ĐẶC ĐIỂM NỔI BẬT\r\n\r\n•  Hỗ trợ tính năng chống ồn chủ động ANC\r\n\r\n•  Tính năng xuyên âm giúp người dùng nghe được âm thanh của môi trường xung quanh\r\n\r\n•  Thời gian sử dụng 4.5 giờ khi bật chế độ chống ồn,19 giờ khi đi kèm với hộp sạc\r\n\r\n•  Trang bị cổng sạc Lightning,5 phút sạc cho 1 giờ sử dụng\r\n\r\n•  Kích hoạt trợ lý ảo Siri bằng cách gọi \"Hey Siri\"\r\n\r\n•  Chống nước chuẩn IPX4 cho phép thoải mái luyện tập mà không lo thấm mồ hôi\r\n\r\n•  Có khả năng định vị tai nghe bị thất lạc\r\n";
        }

        private void pan_acs_picb_ap_3_Click(object sender, EventArgs e)
        {
            pan_detail.Visible = true;
            pan_detial_picb_product.Image = Properties.Resources.acs_9;
            pan_detail_lab_name.Text = pan_acs_lab_ap_3.Text;
            pan_detail_lab_price.Text = airpods_3_price.Text;
            pan_detail_lab_promo.Text = "•  Giảm 300.000đ khi thanh toán qua VNPAY khi mua sản phẩm Airpods\r\n•  Thu cũ Đổi mới: Trợ giá lên đến 500.000 (Tuỳ model, không áp dụng cùng ưu đãi cổng thanh toán)\r\n•  Giảm thêm tới 800.000đ khi mở thẻ TP Bank EVO thành công (Không áp dụng đồng thời KM khác)\r\n";
            pan_detail_lab_policy.Text = "📦 Bộ sản phẩm gồm: Hộp, Cáp USB-C to Lightning, Sách hướng dẫn, Case và tai nghe\r\n🔄 Bảo hành chính hãng 1 năm\r\n🚚 Miễn phí giao hàng\r\n";
            label3.Text = "AppleCare+ cho Tai nghe\r\n\r\nMỗi bộ AirPods, tai nghe Beats đều đi kèm với một năm bảo hành sửa chữa phần cứng và hỗ trợ kỹ thuật miễn phí lên đến 90 ngày.\r\n\r\nAppleCare+ mở rộng phạm vi bảo hiểm của bạn lên hai năm kể từ ngày mua AppleCare+ và bổ sung thêm các sự cố bảo vệ thiệt hại do tai nạn không giới hạn, mỗi sự cố đều phải trả phí dịch vụ $29, cộng với thuế hiện hành. \r\n\r\nNgoài ra, bạn sẽ được ưu tiên tiếp cận các chuyên gia của Apple 24/7 qua trò chuyện hoặc điện thoại.";
            pan_detail_lab_feature.Text = "ĐẶC ĐIỂM NỔI BẬT\r\n\r\n•  Thời lượng pin bền bỉ 6 giờ nghe nhạc, lên đến 30 giờ khi đi kèm hộp sạc\r\n\r\n•  Thiết kế sang trọng, earbuds ôm khít vào tai, điều khiển bằng thao tác chạm - giữ mới lạ\r\n\r\n•  Trải nghiệm sống động hơn với tính năng Spatial Audio độc quyền\r\n\r\n•  Chất lượng âm thanh được xử lý chuyện nghiệp với chip Apple H1\r\n\r\n•  Yên tâm khi luyện tập thể thao, đi mưa khi có chuẩn kháng nước IPX4\r\n\r\n•  Chuẩn Bluetooth 5.0 cho phạm vi kết nối ổn định lên đến 10m\r\n\r\n";
        }

        private void pan_acs_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pan_acs_picb_other_1_Click(object sender, EventArgs e)
        {
            pan_detail.Visible = true;
            pan_detial_picb_product.Image = Properties.Resources.acs_14;
            pan_detail_lab_name.Text = pan_acs_lab_other_1.Text;
            pan_detail_lab_price.Text = other1_price.Text;
            pan_detail_lab_promo.Text = "•  Giảm 300.000đ khi thanh toán qua VNPAY\r\n•  Giảm thêm tới 800.000đ khi mở thẻ TP Bank EVO thành công (Không áp dụng đồng thời KM khác)\r\n";
            pan_detail_lab_policy.Text = "📦 Bộ sản phẩm gồm: AirTag, Sách hướng dẫn\r\n🔄 Bảo hành chính hãng 1 năm\r\n🚚 Miễn phí giao hàng\r\n";
            label3.Text = "AirTag & Environment\r\nApple takes a complete product life cycle approach to determining our environmental impact.\r\n\r\nAirTag is designed with the following features to reduce environmental impact:\r\n100% recycled tin in the solder of the main logic board\r\nMercury-free\r\nBFR-free\r\nPVC-free\r\nBeryllium-free";
            pan_detail_lab_feature.Text = "ĐẶC ĐIỂM NỔI BẬT\r\n\r\n•  Tương thích với các dòng thiết bị chạy IOS 14.5 trở lên\r\n\r\n•  Tính năng định vị độ chính xác cao tương thích với iPhone 11 trở lên cho phép phát và dẫn đường đến vị trí thiết bị\r\n\r\n•  Chế độ thất lạc gửi thông báo khi người dùng ở trong phạm vi kết nối của Airtag hoặc vị trí được tìm thấy trên ứng dụng Find My\r\n\r\n•  Sử dụng pin CR2032 dễ dàng thay thế,có thể sử dụng liên tục trong khoảng 1 năm\r\n\r\n•  Chống nước IP67 bảo vệ thiết bị khỏi tác động môi trường\r\n\r\n";
        }

        private void pan_acs_picb_other_2_Click(object sender, EventArgs e)
        {
            pan_detail.Visible = true;
            pan_detial_picb_product.Image = Properties.Resources.acs_13;
            pan_detail_lab_name.Text = pan_acs_lab_other_2.Text;
            pan_detail_lab_price.Text = other2_price.Text;
            pan_detail_lab_promo.Text = "•  Giảm 300.000đ khi thanh toán qua VNPAY\r\n•  Giảm thêm tới 800.000đ khi mở thẻ TP Bank EVO thành công (Không áp dụng đồng thời KM khác)\r\n";
            pan_detail_lab_policy.Text = "📦 Bộ sản phẩm gồm: Cáp USB-C (1m), Đế sạc MagSafe\r\n🔄 Bảo hành chính hãng 1 năm\r\n🚚 Miễn phí giao hàng\r\n";
            label3.Text = "Tương thích với:\r\niPhone Models\r\niPhone 14 Pro\r\niPhone 14 Pro Max\r\niPhone 14\r\niPhone 14 Plus\r\niPhone 13 Pro\r\niPhone 13 Pro Max\r\niPhone 13 mini\r\niPhone 13\r\niPhone SE (3rd generation)\r\niPhone 12 Pro\r\niPhone 12 Pro Max\r\niPhone 12 mini\r\niPhone 12\r\niPhone 11 Pro\r\niPhone 11 Pro Max\r\niPhone 11\r\n\r\niPhone XS\r\niPhone XS Max";
            pan_detail_lab_feature.Text = "ĐẶC ĐIỂM NỔI BẬT\r\n\r\n•  Bộ sạc MagSafe giúp sạc không dây nhanh chóng. Các nam châm được căn chỉnh hoàn hảo sẽ gắn vào iPhone 14, iPhone 14 Pro, iPhone 13, iPhone 13 Pro, iPhone 12 và iPhone 12 Pro của bạn, đồng thời cung cấp khả năng sạc không dây nhanh hơn lên đến 15W.\r\n\r\n•  Bộ sạc MagSafe duy trì khả năng tương thích với sạc Qi, do đó, nó có thể được sử dụng để sạc không dây cho iPhone 8 trở lên, cũng như các mẫu AirPods có hộp sạc không dây, giống như cách bạn làm với bất kỳ bộ sạc nào được chứng nhận Qi.\r\n\r\n•  Trải nghiệm căn chỉnh từ tính chỉ áp dụng cho các mẫu iPhone 14, iPhone 14 Pro, iPhone 13, iPhone 13 Pro, iPhone 12 và iPhone 12 Pro.\r\n";
        }

        private void picb_search_Click_1(object sender, EventArgs e)
        {
            switch (combox_search.Text.ToLower().Replace(" ", ""))
            {
                case "iphone14pro":
                case "iphone14promax":
                    pan_iphone.Visible = true;
                    foreach (Control c in this.Controls)
                    {
                        if (c is Panel && c != pan_titlebar && c != pan_iphone) c.Visible = false;
                    }
                    pan_iphone_lab_ip14pro_Click(sender, e);
                    break;
                case "iphone14":
                case "iphone14plus":
                    pan_iphone.Visible = true;
                    foreach (Control c in this.Controls)
                    {
                        if (c is Panel && c != pan_titlebar && c != pan_iphone) c.Visible = false;
                    }
                    pan_iphone_lab_ip14_Click(sender, e);
                    break;
                case "iphone13":
                case "iphone13mini":
                    pan_iphone.Visible = true;
                    foreach (Control c in this.Controls)
                    {
                        if (c is Panel && c != pan_titlebar && c != pan_iphone) c.Visible = false;
                    }
                    pan_iphone_lab_ip13_Click(sender, e);
                    break;
                case "macbookpro16inchm1max":
                case "macbookpro14inchm1max":
                    pan_mac.Visible = true;
                    foreach (Control c in this.Controls)
                    {
                        if (c is Panel && c != pan_titlebar && c != pan_mac) c.Visible = false;
                    }
                    pan_mac_lab_pro_Click(sender, e);
                    break;
                case "macbookairm210-coregpu":
                case "macbookairm28-coregpu":
                    pan_mac.Visible = true;
                    foreach (Control c in this.Controls)
                    {
                        if (c is Panel && c != pan_titlebar && c != pan_mac) c.Visible = false;
                    }
                    pan_mac_lab_air_Click(sender, e);
                    break;
                case "imac24inchm18-coregpu":
                case "imac24inchm17-coregpu":
                    pan_mac.Visible = true;
                    foreach (Control c in this.Controls)
                    {
                        if (c is Panel && c != pan_titlebar && c != pan_mac) c.Visible = false;
                    }
                    pan_mac_lab_air_Click(sender, e);
                    break;
                case "ipadair5":
                    pan_ipad_picb_air5_Click(sender, e);
                    break;
                case "ipadprom211inch":
                    pan_ipad_picb_pro2_Click(sender, e);
                    break;
                case "applewatchulrta":
                    pan_acs_picb_watch_1_Click(sender, e);
                    break;
                case "applewatchseries8" :
                    pan_acs_picb_watch_2_Click(sender,e);
                    break;
                case "airpodspro2":
                    pan_acs_picb_ap_1_Click(sender, e);
                    break;
                case "airpods3":
                    pan_acs_picb_ap_2_Click(sender, e);
                    break;
                case "airpodspro":
                    pan_acs_picb_ap_3_Click(sender, e);
                    break;
                case "airtag":
                    pan_acs_picb_other_1_Click(sender, e);
                    break;
                case "sạcmagsafe":
                    pan_acs_picb_other_2_Click(sender, e);
                    break;
            }
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void picb_cart_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is Panel && c != pan_titlebar && c != pan_cart) c.Visible = false;
            }
            pan_cart.Visible = true;
        }

        private void AMainForm_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ProductID", typeof(string));
            dt.Columns.Add("ProductName", typeof(string));
            dt.Columns.Add("ProductPrice", typeof(string));
            dt.Columns.Add("ProductQuantity", typeof(string));
            dt.Columns.Add("TotalPrice", typeof(string));
        }

        private void combox_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                picb_search_Click_1(sender, e);
                e.Handled = true;
            }
            
        }
    }


}
